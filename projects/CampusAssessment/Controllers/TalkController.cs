﻿using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNet.Mvc;
using CampusAssessment.Models;
using System.Net;
using System.Web.Http;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CampusAssessment.Controllers
{
    [Route("api/[controller]")]
    public class TalksController : Controller
    {
        Talk[] talks = new Talk[]
        {
            new Talk {id = "A1", title = "Zurück auf Anfang", reviews=new List<Review> { new Review {name="tester", positives="fast alles", missing="nix", rating= 2, experience=1,topic=1} },                                  speaker = new Speaker {name ="Max2", email = "max2@comp2.de", company= "comp2"},     caption= "Java Enterprise im Zeitalter moderner Web-Technologien",    text= "Seit über 15 Jahren bauen wir Mehrschicht­anwendungen mit der Java EE, und seit den ersten Tagen gibt es Stimmen, dass das alles doch noch einfacher, schöner und moderner gehen muss. Speziell im Web-Umfeld setzen sich inzwischen leichtgewichtigere und gleichzeitig mächtigere Ansätze durch: Die Logik wandert wieder zurück in den Client, und Server-seitig aufbereitete Web-Seiten erscheinen altbacken. Doch halt! Die JEE ist deutlich mehr als JSF oder ein schwergewichtiger Full-Stack-Server. Vielmehr handelt es sich um eine Sammlung von aufeinander abgestimmten Einzeltechnologien, die eigentlich auch und gerade für den Einsatz mit Rich-Clients gedacht ist.\nDer Vortrag zeigt, wie moderne JEE-Technologien im Server-Backend mit modernen Web-Technologien im Frontend zusammenspielen können und dabei Anforderungen, wie die Unterstützung heterogener Client-Landschaften, erfüllt werden können."},
            new Talk {id = "A2", title = "Fix, fix!",                                          speaker = new Speaker {name ="Max2", email = "max2@comp2.de", company= "comp2"},     caption= "Entwicklung mit JavaFX",                                    text= "Trotz eines gewissen Grades an Verunsicherung wegen fehlender Informationen und Missinterpretation der Fakten etabliert sich JavaFX als neue UI-Technologie in JavaSE8. Denn die vielfältigen Verbesserungen von JavaFX bei der Erstellung von Rich-Internet-Anwendungen erleichtern den Entwicklern das Leben erheblich.\nIn diesem Vortrag wird das Konzept und das Potenzial von JavaFX besprochen und die einzelne Bestandteile von JavaFX demonstriert. Dabei wird unter anderem auf den aktuellen Status von JavaFX 8, das Open-Source-Projekt OpenJFX, die Migration von Swing-Komponenten, die Barrierefreiheit und das automatisierte Testen von JavaFX-GUI-Komponenten eingegangen."},
            new Talk {id = "A3", title = "Sekt oder Selters?",                                 speaker = new Speaker {name ="Max3", email = "max3@comp3.de", company= "comp3"},     caption= "Hat Java auf dem Client eine Zukunft?",                     text= "Nach der Ablösung von Swing durch JavaFX haben viele auf eine Renaissance von Java auf dem Client gehofft. Dazu ist es bis jetzt nicht gekommen. Um die Frage nach dem „Warum?“ beantworten zu können, ist zuerst die Klärung des Begriffs „Client“ nötig: Auf welchen Geräten kann oder soll Java überhaupt ausgeführt werden? Auf den „hippen“ mobilen Plattformen hatte es die Sprache von Anfang an schwer. Und die Bedeutung des klassischen PC wird kontinuierlich geringer. \nDieser Vortrag beleuchtet, welche Auswirkungen dieser Wandel auf die Wahl einer geeigneten Oberflächentechnologie hat. Und er zeigt nicht nur Szenarien auf, in denen „klassisches“ Java für die GUI weiterhin sinnvoll ist, sondern stellt auch mögliche Alternativen vor."},
            new Talk {id = "B1", title = "Mit Doppel-Aa",                                      speaker = new Speaker {name ="Max4", email = "max4@comp4.de", company= "comp4"},     caption= "Die Programmiersprache Aalgola",                            text= "Wer lange genug mit der Programmiersprache seiner Wahl gearbeitet hat, wird damit eigentlich auch alles, was er machen muss, machen können. Dennoch gibt es dann immer wieder Kleinigkeiten, bei denen man sich etwas schwerer tut, weil es dann doch keine vereinfachende Sprachunterstützung gibt. Hier soll die Programmiersprache Aalgola Abhilfe schaffen.\nDieser Vortrag führt praktisch (sic!) in die Programmiersprache Aalgola ein und zeigt, wie sie die kleinen Probleme des alltäglichen Entwicklerdaseins behebt, das Arbeiten vereinfacht und Missstände, wie sie etwa in Java-ähnlichen Programmiersprachen bestehen, behebt."},
            new Talk {id = "B2", title = "Ex Machina",                                         speaker = new Speaker {name ="Max5", email = "max5@comp5.de", company= "comp5"},     caption= "Wie man mit Gradle App-Varianten testet und baut",          text= "Seitdem Android Studio für die native App-Entwicklung Pflicht ist, müssen wir Entwickler uns nicht nur mit dem Build-Tool Gradle anfreunden, sondern auch die Android-spezifischen Erweiterungen verstehen.\nFolgen Sie in diesem Vortrag dem Referenten bei dem Versuch, das Dickicht der Module, der Flavors und der Variants zu lichten."},
            new Talk {id = "B3", title = "Gut geschnitten",                                    speaker = new Speaker {name ="Max6", email = "max6@comp6.de", company= "comp6"},     caption= "API-Design für (Java-)Entwickler",                          text= "Mit APIs haben Entwickler täglich zu tun. Sie dienen beispielsweise zur Arbeitsteilung, Wiederverwendung von Bibliotheken oder Bildung einer modularen Code-Basis. Ihre primäre Aufgabe ist dabei die Kommunikation zwischen den Entwicklern, so dass APIs beim Entwurf immer aus der Perspektive der späteren Benutzer – der Entwickler – betrachtet und beurteilt werden müssen.\nDer Vortrag beschreibt die Bedeutung von APIs für die Architektur und stellt ebenso den Zusammenhang zu „Clean Code“ her. Die Eigenschaften, die gute APIs aufweisen sollten, werden hier beschrieben und anhand vieler Positiv- und Negativbeispiele veranschaulicht."},
            new Talk {id = "C1", title = "Change the Change",                                  speaker = new Speaker {name ="Max7", email = "max7@comp7.de", company= "comp7"},     caption= "Eine Einführung in Lean Change Management",                 text= "Eine Einführung von Scrum in ein Team gelingt oft relativ leicht, eine Änderungen auf Organisationsebene dagegen nicht unbedingt. Diese Erfahrung hat wohl jeder schon gemacht, der als Scrum Master, Agile Coach oder Change Agent die agile Transition eines Unternehmens oder großen Projekts begleitet hat. Widerstand gegen Veränderungen ist eine natürliche Reak­tion, wenn die von der Veränderung betroffenen Menschen nicht in die Gestaltung der Änderung eingebunden sind. Lean Change Management ist ein Ansatz, der diese Widerstände vermeidet, indem Änderungen und deren Einführungsprozess gemeinsam gestaltet werden. Die Praktiken von Lean Change Management kombinieren Ideen aus Agilem Management, Lean Start Up, Change Management sowie aus Organisations­entwicklung und Organisationspsychologie. Lean Change Management ändert grundlegend, wie wir über Änderungen denken. \nIn diesem Vortrag lernen Sie die grundlegenden Ideen von Lean Change und einige konkrete Praktiken kennen, die Sie sofort einsetzen können – Quick Wins sind ein wesentlicher Erfolgsfaktor bei Änderungsprozessen."},
            new Talk {id = "C2", title = "Tausend auf einen Streich",                          speaker = new Speaker {name ="Max8", email = "max8@comp8.de", company= "comp8"},     caption= "Wie man den Computer dazu bringt, Testfälle zu schreiben",  text= "Das man als Entwickler nicht nur Produktions-Code sondern auch Tests zu schreiben hat, ist mittlerweile ein alter Hut. Trotzdem ist es für viele eine lästige und monotone Arbeit. Außer­dem ist es noch lange nicht garantiert, dass Unit-Tests auch wirklich alle Grenz- und Nicht-Grenz-Fälle abdecken. Ein moderner Ansatz ist eigenschaftsbasiertes Testen, bei dem eine abstrakte Bedingung spezifiziert wird, die dann vom Test-Framework automatisch überprüft wird. \nIn diesem Vortrag wird es um die Bibliothek „QuickCheck“ und einige weiterführende Techniken gehen, mit denen man – mit vertretbarem Aufwand – Tests deutlich zuverlässiger machen kann."},
            new Talk {id = "C3", title = "Klammern! Klammern überall!",                        speaker = new Speaker {name ="Max9", email = "max9@comp9.de", company= "comp9"},     caption= "Single Page Apps mit Clojure und ClojureScript",            text= "Sie kennen Clojure und ClojureScript noch nicht (besonders gut) und befürchten, dass Sie den LISP-artigen Code nicht lesen können? \nKein Problem: Vor dem Einstieg in die Details der Anwendung, gibt dieser Vortrag einen kurzen Überblick über die Programmiersprache Clojure. Anhand eines konkreten Beispiels wird dann gezeigt, wie mit Clojure und ClojureScript eine Single-Page-Web-Anwendung entwickelt werden kann. Client-seitig wird die Anwendung React verwenden, um die Seiten zu rendern. Auch Server-seitiges Rendering wird unterstützt."},
            new Talk {id = "D1", title = "Fitnesstraining fürs Gehirn – und Geist und Seele",  speaker = new Speaker {name ="Max10", email = "max10@comp10.de", company= "comp10"}, caption= "Achtsamkeit und Emotionale Intelligenz für Techniker",      text= "Achtsam, was? Allerspätestens, wenn man dann den Begriff „Emotionale Intelligenz“ fallen lässt, schauen Software-Entwickler einen gerne schräg an. Dieses „weiche Zeug“ in unserem technischen Geschäft? Aber auch Projektleiter reagieren erstmal skeptisch. Von der Maslowschen Bedürfnispyramide hat man ja vielleicht schon mal etwas gehört. Doch Achtsamkeit und Emotionale Intelligenz? Das ist jetzt doch wirklich eher was für die private Ecke: Entspannung, Runterkommen und so. Wir sind doch hier im „harten Business“! Doch ist das wirklich so? Selbst Google bietet bereits mit „Search Inside Yourself“ ein eigenes Programm zu genau diesen Themen für seine (technischen) Mitarbeiter an. Ist da dann vielleicht doch etwas dran? \nDer Vortrag gibt einen Einblick in die Themen Achtsamkeit und Emotionale Intelligenz und zeigt vor allem auf, was dieser „Werkzeugkasten“ gerade uns Technikern bringen kann: bei der Arbeit, für die Arbeit – und natürlich auch privat."}
        };

        // GET: api/talks
        [HttpGet]
        public IEnumerable<Talk> Get()
        {
            return talks;
        }

        // GET api/talks/5
        [HttpGet("{id}")]
        public Talk Get(string id)
        {
            var talk = talks.FirstOrDefault(x => x.id.ToLower() == id.ToLower());
            if (talk == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return talk;
        }

        //// POST api/talks
        //[HttpPost]
        //public void Post([FromBody]string value)
        //{
        //}

        //// PUT api/talks/5
        //[HttpPut("{id}")]
        //public void Put(int id, [FromBody]string value)
        //{
        //}

        //// DELETE api/talks/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}

        // PUT api/talks/5
        [HttpPost("{id}")]
        public Talk AddReview(string id, [FromBody]Review review)
        {
            var talk = talks.FirstOrDefault(x => x.id.ToLower() == id.ToLower());
            if (talk == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            talk.reviews.Add(review);

            return talk;
        }
    }
}
