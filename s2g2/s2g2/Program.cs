using System;
using System.Collections.Generic;

namespace CVApplication
{
    class Program
    {
        static void Main(string[] args)
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

            StampaDettagliCVSuSchermo(mioCV);
        }

        static void StampaDettagliCVSuSchermo(CV cv)
        {
            Console.WriteLine("=== INFORMAZIONI PERSONALI ===");
            Console.WriteLine($"Nome: {cv.InformazioniPersonali.Nome}");
            Console.WriteLine($"Cognome: {cv.InformazioniPersonali.Cognome}");
            Console.WriteLine($"Telefono: {cv.InformazioniPersonali.Telefono}");
            Console.WriteLine($"Email: {cv.InformazioniPersonali.Email}");
            Console.WriteLine();

            Console.WriteLine("=== STUDI EFFETTUATI ===");
            foreach (var studi in cv.StudiEffettuati)
            {
                Console.WriteLine($"Qualifica: {studi.Qualifica}");
                Console.WriteLine($"Istituto: {studi.Istituto}");
                Console.WriteLine($"Tipo: {studi.Tipo}");
                Console.WriteLine($"Dal: {studi.Dal}");
                Console.WriteLine($"Al: {studi.Al}");
                Console.WriteLine();
            }

            Console.WriteLine("=== IMPIEGHI ===");
            foreach (var impiego in cv.Impieghi)
            {
                foreach (var esperienza in impiego.Esperienze)
                {
                    Console.WriteLine($"Azienda: {esperienza.Azienda}");
                    Console.WriteLine($"Job Title: {esperienza.JobTitle}");
                    Console.WriteLine($"Dal: {esperienza.Dal}");
                    Console.WriteLine($"Al: {esperienza.Al}");
                    Console.WriteLine($"Descrizione: {esperienza.Descrizione}");
                    Console.WriteLine($"Compiti: {esperienza.Compiti}");
                    Console.WriteLine();
                }
            }
        }
    }

    public class CV
    {
        public InformazioniPersonali InformazioniPersonali { get; set; }
        public List<Studi> StudiEffettuati { get; set; }
        public List<Impieghi> Impieghi { get; set; }
    }

    public class InformazioniPersonali
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
    }

    public class Studi
    {
        public string Qualifica { get; set; }
        public string Istituto { get; set; }
        public string Tipo { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
    }

    public class Impieghi
    {
        public List<Esperienza> Esperienze { get; set; }
    }

    public class Esperienza
    {
        public string Azienda { get; set; }
        public string JobTitle { get; set; }
        public string Dal { get; set; }
        public string Al { get; set; }
        public string Descrizione { get; set; }
        public string Compiti { get; set; }
    }
}