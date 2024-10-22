# Properties

In C# gibt es die Funktion Auto-Properties mit welchen wir nicht für jedes Attribut zwei Methoden für das Abrufen und Setzen des Wertes definieren
müssen.

<tabs>
  <tab title="Ohne Auto-Properties">
    <code-block lang="c#" src="circle-1.cs"/>
  </tab>
  <tab title="Mit Auto-Properties">
    <code-block lang="c#" src="circle-2.cs"/>
  </tab>
</tabs>

Wie man sieht, wird der code deutlich kürzer und auch lesbarer.

Um ein Property read-only bzw. write-only zu machen, können wir einfach den `setter` bzw. `getter` auslassen.

> Zudem gibt es noch weitere mögliche Werte für das Schreiben, z.B. `private set;` oder `init;`.