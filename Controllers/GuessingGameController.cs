 
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebUtbApp.Controllers
{
	public class GuessingGameController : Controller
	{

        public IActionResult GuessingGame()
		{
			// Get a new random number for the player to guess
			HttpContext.Session.SetInt32("secretNr", value: new Random().Next(1, 101));

			// Clearing all
			ViewBag.guessResultString = null;
			ViewBag.newGame = null;

			return View();
		}

		[HttpPost]
		public IActionResult GuessingGame(string playerGuess)
        {
			
			ViewBag.newGame = null;

			//Getting the number to be able to see if player guess right
			int secretNr = HttpContext.Session.GetInt32("secretNr") ?? 0;

			if (!int.TryParse(playerGuess, out int guess))
			{
				//Only integer numbers are valid
				ViewBag.guessResultString = "You have to enter an integer number!";
			}
			else if (guess <= 0 || guess > 100)
			{
				// The guessed number must be in range
				ViewBag.guessResultString = "Your guessed number must be between 1 and 100.";
			}
			else if (secretNr <= 0 || secretNr > 100)
			{
				// Check if the secret number is still valid
				// or the session timed out.
				ViewBag.guessResultString = "The secret number was lost.";
				ViewBag.newGame = $"A new secret number has been generated!";

				//A new valid secret number is needed
				HttpContext.Session.SetInt32("secretNr", new Random().Next(1, 101));
			}
			else if (guess < secretNr)
			{
				ViewBag.guessResultString = $"Your guessed number is too low ({guess}).";
			}
			else if (guess > secretNr)
			{
				ViewBag.guessResultString = $"Your guessed number is too high ({guess}).";
			}
			else if (guess == secretNr)
			{
				ViewBag.guessResultString = $"Congratulations!!! You guessed the right number ({secretNr}).";
				ViewBag.newGame = $"A new secret number has been generated!";

				// Start a new game
				HttpContext.Session.SetInt32("secretNumber", new Random().Next(1, 101));

			}
			else
			{
				// Eh ... IDK
				ViewBag.guessResultString = "Unkown error!";
			}
			return View();
		}
	}
}