using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Identity;
using BrightIdeas.Models;

namespace BrightIdeas.Controllers
{
    public class HomeController : Controller
    {
        private MyContext _context;

         private int? uid
        {
            get { return HttpContext.Session.GetInt32("UserId"); }
        }
        private bool isLoggedIn
        {
            get { return uid != null; }
        }

        // here we can "inject" our context service into the constructor
        public HomeController(MyContext context)
        {
            _context = context;
        }
        [HttpGet("")]
        public IActionResult Index()
        {
           
           
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


        [HttpPost("register")]
        public IActionResult Register(User user)
        {
            // Check initial ModelState => if there are no errors
            if (ModelState.IsValid)
            {
                // If a User exists with provided email
                if (_context.Users.Any(u => u.Email == user.Email))
                {
                    // Manually add a ModelState error to the Email field, with provided
                    // error message
                    ModelState.AddModelError("Email", "Email already in use!");
                    // You may consider returning to the View at this point
                    return View("Index");
                }
                // if we reach here it confirms this is new user
                // add them to db... after we hash the password
                PasswordHasher<User> Hasher = new PasswordHasher<User>();
                user.Password = Hasher.HashPassword(user, user.Password);
                _context.Users.Add(user);
                _context.SaveChanges();
                // save their id to session
                HttpContext.Session.SetInt32("UserId", user.UserId);
                // redirect to Dashboard
                return RedirectToAction("Dashboard");
            }
            // other code
            return View("Index");

        }
        [HttpPost("login")]
        public IActionResult LogIn(Login user)
        {
            if (ModelState.IsValid)
            {
                // If inital ModelState is valid, query for a user with provided email
                var userInDb = _context.Users.FirstOrDefault(u => u.Email == user.LoginEmail);
                // If no user exists with provided email
                if (userInDb == null)
                {
                    // Add an error to ModelState and return to View!
                    ModelState.AddModelError("LoginEmail", "Invalid Email/Password");
                    return View("Index");
                }
                // Initialize hasher object
                var hasher = new PasswordHasher<Login>();
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(user, userInDb.Password, user.LoginPassword);

                // result can be compared to 0 for failure
                if (result == 0)
                {
                    // handle failure (this should be similar to how "existing email" is handled)
                    ModelState.AddModelError("LoginPassword", "Invalid Email/Password");
                    return View("Index");
                }
                // if result is not 0, then it is valid
                // Store user id into session
                HttpContext.Session.SetInt32("UserId", userInDb.UserId);
                return RedirectToAction("Dashboard");
            }
            return View("Index");
        }
      
        [HttpGet("logout")]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index");
        }


        [HttpGet("bright_ideas")]
        public IActionResult Dashboard()
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index");
            }
            
            ViewBag.CurrentUser = _context.Users
            .Where(u => u.UserId == (int)HttpContext.Session.GetInt32("UserId"))
            .Single();

            ViewBag.AllIdeas = _context.Ideas
            .Include(u => u.PostedBy)
            .Include(l => l.Likedby)
            .OrderByDescending(l => l.Likedby.Count)
            .ToList();
            
            return View("Dashboard");
        }

        [HttpPost("postidea")]
        public IActionResult PostIdea(string NewIdea)
        {
          if (NewIdea.Length < 5)
            {
                ModelState.AddModelError("NewIdea", "Must be at least 5 characters");
            }
            // run validation
            if (ModelState.IsValid)
            {
                // store idea in db
                Idea Idea1 = new Idea();
                
                Idea1.UserId = (int)uid;
                Idea1.NewIdea = NewIdea;
                
                _context.Ideas.Add(Idea1);
                _context.SaveChanges();
               return RedirectToAction("Dashboard");
            }
            ViewBag.CurrentUser = _context.Users
            .Where(u => u.UserId == (int)uid)
            .Single();

            ViewBag.AllIdeas = _context.Ideas
            .Include(u => u.PostedBy)
            .Include(l => l.Likedby)
            .OrderByDescending(l => l.Likedby.Count)
            .ToList();

            return View("Dashboard");
        }

        [HttpGet("like/{ideaId}")]
        public IActionResult Like(int ideaId)
        {
            // create new Like instance
            Like like = new Like();
            // reassign UserId and IdeaId
            like.UserId = (int)uid;
            like.IdeaId = ideaId;
            // Add to Likes table in db
            _context.Likes.Add(like);
            // save changes
            _context.SaveChanges();
            // redirect dashboard
            return RedirectToAction("Dashboard");
        }
        [HttpGet("unlike/{ideaId}")]
        public IActionResult Unlike(int ideaId)
        {
            // query Like from db
            // must match the ideaId and userId in the 1 Like relationship
            Like unlike = _context.Likes
            .FirstOrDefault(l => l.FanOf.IdeaId == ideaId && l.User.UserId == (int)uid);
            // Add to Likes table in db
            _context.Likes.Remove(unlike);
            // save changes
            _context.SaveChanges();
            // redirect dashboard
            return RedirectToAction("Dashboard");
        }

        [HttpGet]
        [RouteAttribute("users/{userId}")]
        public IActionResult UserInfo(int userId)
        {
            if (HttpContext.Session.GetInt32("UserId") == null ){
                return RedirectToAction("Index");
            } 
            ViewBag.SelectedUser = _context.Users
            .Where(u => u.UserId == userId)
            .Include(i => i.UsersIdeas)
            .Include(l => l.UserLikes)
            .Single(); 
            return View();
        }
        [HttpGet]
        [RouteAttribute("bright_ideas/{ideaId}")]
        public IActionResult IdeaInfo(int ideaId)
        {
            if (!isLoggedIn)
            {
                return RedirectToAction("Index");
            }
            ViewBag.SelectedIdea = _context.Ideas.Where(i => i.IdeaId == ideaId)
            .Include(u => u.PostedBy)
            .Include(l => l.Likedby)
            .ThenInclude(u => u.User)
            .Single(); 
            ViewBag.LikedBy = _context.Likes
            .Where(i => i.IdeaId == ideaId)
            .ToList();
            return View();
        }
        [HttpGet]
        [RouteAttribute("deleteidea/{ideaId}")]
        public IActionResult DeleteIdea(int ideaId)
        {
           
            if (!isLoggedIn)
            {
                return RedirectToAction("Index");
            }
            // query ideas db by id
            Idea delIdea = _context.Ideas.FirstOrDefault(m => m.IdeaId == ideaId);
            // remove from db
            _context.Ideas.Remove(delIdea);
            // save changes
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}
