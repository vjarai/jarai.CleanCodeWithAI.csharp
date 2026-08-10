Verantwortung beim Programmieren mit KI bleibt bei Entwickler!
- Änderungen sind zu prüfen/bewerten
- 2 Konzepte:
    großes "Script"-Prompt mit detailierten Anweisungen des gesamten Problems
        Vorteil: Hoffnung auf wiederverwendbarkeit
    schrittweise "chatten"
        Vorteil: vorgehensweise nachvollziehbarer und Falsche Wege können frühzeitig korrigiert werden
- je präziser die benutzten Begriffe (welche pattern, SOLID-Prinzip) im Prompt sind, desto genauer werden die Ergebnisse (logisch, aber sehr relevant)

Glossar:
SOLID-Prinzipien
- sehr wichtig

Single Responsiblity Prinzip
- kleine Klassen/Methoden (5 Zeile Code)

Liskov Substitution Principle
- benutze Vererbung aus Gründen der Austauschbarkeit
- Benutze Aggregation(pointer, kann auch allein existieren) Komposition(kann nicht allein existieren) aus Gründen der Wiederverwertung (kann woanders wieder verwendet werden)


überladen:
ändern der Eingabeparameter
Konstruktor (Init, Ressourcen bereitstellen)
Destruktor (Freigabe der Ressourcen)
überschreiben: methode funktional erweitert/ändern (muss in C++ override sein in Tochterklasse <-dadurch Prüfung, ob Mehtode in Vaterklasse vorhanden; muss in Vaterklasse virtual sein)
virtual (Methode) kostet rechenzeit, reduziert Abfragen, da spätes Binden möglich

spätes Binden:
vorausgesetzt in Basisklasse Virtual -> dadurch kann bei Überschreiben in Tochterklasse ein anderer Code ausgeführt werden
spätes Binden funktioniert nur mit Pointern

klasse kann mehrere Konstruktoren -> dadurch verschiedene Arten eine Klasse zu erstellen/instanzieren -> mit/ohne konstruktor

open/close-Prinzip:
wenn ich an einer Klasse etwas ändere und dadurch an anderen Klassen etwas ändern muss, dann besser nicht
-> keinen Code ändern, sondern neue Klassen schreiben

Interface Segregation Principle:
- Interfaces sollten klein sein

Dependency Inversion Principle:
- keine Abhängigkeit von hochrangigen zu niedrigrangigen Verbindungen

KISS (KeepItStupidAndSimple)
- jede Aufgabe für sich betrachten
- nicht zu viel abstrahieren
YAGNI (YouAintGoneNeedIt)
- Gegenteil von Kiss

Triple A bei Testing
Arrange, Act, Assert
Vorbereiten
Ausführen
Überprüfen

Empfehlungen/Anmerkungen:
Clean Code-Buch
"Rubber Duck"-Prinzip: durch Formulierung des Problems (erklärung an einen anderen) das Problem lösen
refactoring.guru als Webseite zum Nachschlagen

Code-Metriken: zb Lines of Code pro Methode
- kann COdequalität bewerten, aber Bewertung ebenfalls Zeitintensiv und keine festen Richtwerte



Pattern:
- verschiedene Programmierprinzipien für wiederkehrende Probleme
- z.B.
    - Adapter-Pattern (haüfig verwendet) -> nicht zusammenpassende Klassen austauschbar machen -> Bsp. IpHone mit USB laden
    - Pull-Up-Pattern -> ziehe geimensamkeiten zusammen "nach oben"
    - State-pattern -> Bisisklasse "Zustand" (enthält alle Verhalten mit Exceptions) und abgeleitete Zustandsklassen, die Verhalten überschreiben und dadurch Folgezustände auslösen durch Übergabe des aktuellen Zustands
    - class based design pattern: sequenziell
    - task based asyn pattern: gleichzeitige Abarbeitung 
    - consumer producer pattern

Big O Notation: wie viel mehr Rechenzeit benötigt der Algorithmus bei Verarbeitung mehrerer 


bei Refactoring: erster Schritt: generiere Tests, damit vorhandene Funktionalität erkannt und sichergestellt werden kann, dass nach Änderung die Funktionalität noch vorhanden ist


BeispielPrompts:
können in Prompts als .prompt.md hinterlegt werden, um später direkt darauf zuzugreifen und nciht jedes mal neu geschirben zu werden
Suggest refactoring to solid principles -> refactored den Code

pullup refactoring

generate UML diagram as PlantUML

/tests

flatten nested ifs

generate xml comments for all classes, public methods, fields and properties
generate md documentation
@workspace -> angezeigtes Dokument
@project -> projekt

check code for known vulnerabilities
check code for security issues

hilfreiche Befehle:
dotnet test (braucht [FACT] als signalisierung für einen Test, kein Main, da sonst "mehrere Einstiegspunkte") zumAusführen von Tests von C# in VSCode

dotnet build

in VS :
muq-Bibliothek für die Erstellung von Mocks (simulierte Aggregate) (sollte auch in anderen IDEs nutzbar)
Projekt = 1 Programm
Solution = Programme, die beziehung haben können -> gesamter Ordner

Code Coverage -> Testabdeckung wird geprüft

ModelContextProtocoll:
KI bindet "externe Systeme" ein, z.B. Compiler und Terminal zum kompilieren und ausführen -> muss aktuell durch Benutzer freigegeben werden

KI-gestützes testdriven design:
Test = maschinenlesbare Spezifikation
Vorgehen:
zuerst High level Test, dann Tests itarieren zu Low Level Test (bis unit)
-> Anschließend Coding, um Tests zu erfüllen, von Low zu High
ODER
High-Level implementieren, anschließend "einfachen" (ohne großartigen Inhalt) Code implementieren, der Anforderung erfüllt
nächste High-Level Anforderung -> erzeugter Code wird "besser" (Code passt besser zum Endergebnis)
itarieren durch alle High-Level Anfroderungen, jeweils vorhandene Tests nochmal durchprüfen
-> zum Schluss Unit-Tests ergänzen

Fehlerquelle: Lücken in der Spezifikation, die implizit vorausgesetzt werden, könnten fehlen zB:
    Defaultverhalten
    andere "Grundlagen"-Funktionalitäten sollen auch funktionieren
    Exceptions oder Verhalten, dass sich aus Problem-Kontext ergeben müsste

Daten- und Performance-Tuning:
klassische Profiler in IDE nutzen

Datenbanken:
ORMapper, um Datenbanken (Datenbankmodell) mit Objektorientierter Programmierung (Klassenmodell) zusammen zu bringen
-> Beispiel DoJo4, mit SQL und CS-spezifischer implementierung
Entity Relationchip (ER) Diagramme
Vererbung in Datenbank:
- Table per hirarchie: in bestehende Tabelle der Vaterklasse
- table per class: eigene Tabelle
- noch eine dritte Möglichkeit...

generierung plant UML in CsCode:
Erweiterung PlantUML & PlantUML Previewer installieren
puml von copilot erzeugen lassen
STR + SHIFT + P (Befehlspalette) -> nach plantUML suchen und "Preview current diagram" ausführen
Java runtime muss installiert sein

In Cs:
asynch in definition
await in aufruf

ui:
(älter, einfach) Windows Forms UI

Documentationen erstellen lassen:
Klassendiagramme, ERDiagramme (Datenbank)
md-documentation
git commit messages
release notes
arc42 (Konzept zum beschreiben von SoftwareArchitektur)

code auf Fehler, bekannte Vulnerabilities, Security issus und Definition gaps prüfen lassen

MCP (Model Context Protocol)
https://modelcontextprotocol.io/docs/getting-started/intro
- Erweiterung der AI durch spezialisiertes Wissen (z.B. Firmenspezifisch, wie guidelines)
- standardisierte MCP-API, über die auf externe Server zugegriffen werden kann
- MCP Server kann Lokal oder Extern sein

- z.B. MCP für Dateisystem oder für GitHub
- Konfiguration der Server in Datei .mcp.json -> Projekt ModelContextProtocol
- in vs code vermutlich am einfachsten einen eigenen MCP-Server programmieren zu lassen.
- in vs konfigurieren 

openAPIAutomation:
programmgesteuert die AI ansprechen

repository custom instructions
verschiedene Regeln hinterlegen, die bei jeder Anfrage mitgegeben werden