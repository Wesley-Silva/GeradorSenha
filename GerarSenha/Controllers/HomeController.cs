using GerarSenha.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace GerarSenha.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            SenhaViewModel model = new SenhaViewModel();

            model.ListaCheckBoxes = new List<CheckBoxItem>
            {
                new CheckBoxItem
                {
                    Id = 1,
                    Title = "Letras",
                    IsChecked = false
                },
                new CheckBoxItem
                {
                    Id = 2,
                    Title = "Números",
                    IsChecked = false
                },
                new CheckBoxItem
                {
                    Id = 3,
                    Title = "Símbolos",
                    IsChecked = false
                },
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Index(SenhaViewModel model)
        {
            int numeroSenha = 10;

            if (model.Caracteres > 30) return View(model);

            string chars = "";
            if (model.ListaCheckBoxes.Any(c => c.Title == "Letras" && c.IsChecked == true))
            {
                chars += "abcdefghijlmnopqrstuvxyzABCDEFGHIJLMNOPQRSTUVXYZ";
            }
            if (model.ListaCheckBoxes.Any(c => c.Title == "Números" && c.IsChecked == true))
            {
                chars += "0123456789";
            }
            if (model.ListaCheckBoxes.Any(c => c.Title == "Símbolos" && c.IsChecked == true))
            {
                chars += "#/$!?=-\"";
            }

            Random rnd = new Random();
            string senha = "";
            List<string> sb = new List<string>();
            var items = new List<string>();

            for (int i = 0; i < numeroSenha; i++)
            {
                for (int j = 0; j < model.Caracteres; j++)
                {
                    int pos = rnd.Next(0, chars.Length);
                    senha += chars[pos].ToString();
                }
                sb.Add(senha);
                senha = string.Empty;
            }
            model.ListaString = sb;
            ViewBag.senhas = model.ListaString;

            return View(model);
        }
    }
}
