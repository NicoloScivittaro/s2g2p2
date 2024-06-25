using Microsoft.AspNetCore.Mvc;
using s2g2p2.Models;
using System.Collections.Generic;

namespace s2g2p2.Controllers
{
    public class CVController : Controller
    {
        public IActionResult Index()
        {
            CV mioCV = new CV
            {
                InformazioniPersonali = new InformazioniPersonali
                {
                    Nome = "Mario",
                    Cognome = "Rossi",
                    Telefono = "1234567890",
                    Email = "mario.rossi@example.com"
                },
                StudiEffettuati = new List<Studi>
                {
                    new Studi
                    {
                        Qualifica = "Laurea in Informatica",
                        Istituto = "Università di Roma",
                        Tipo = "Università",
                        Dal = "2015",
                        Al = "2018"
                    },
                    new Studi
                    {
                        Qualifica = "Diploma di Maturità Scientifica",
                        Istituto = "Liceo Scientifico Galileo Galilei",
                        Tipo = "Scuola Superiore",
                        Dal = "2010",
                        Al = "2015"
                    }
                },
                Impieghi = new List<Impieghi>
                {
                    new Impieghi
                    {
                        Esperienze = new List<Esperienza>
                        {
                            new Esperienza
                            {
                                Azienda = "Tech Solutions",
                                JobTitle = "Software Developer",
                                Dal = "2019",
                                Al = "2021",
                                Descrizione = "Sviluppo di applicazioni web.",
                                Compiti = "Progettazione, sviluppo e manutenzione di software."
                            },
                            new Esperienza
                            {
                                Azienda = "Innovative Apps",
                                JobTitle = "Junior Developer",
                                Dal = "2018",
                                Al = "2019",
                                Descrizione = "Supporto nello sviluppo di applicazioni mobile.",
                                Compiti = "Scrittura di codice, testing e debugging."
                            }
                        }
                    }
                }
            };

            return View(mioCV);
        }
    }
}