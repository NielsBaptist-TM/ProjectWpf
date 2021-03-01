# ProjectWpf
This is my project repo for the board game Trivial Pursuit that i'm making for the course WPF.
Resources:
- Quiz game in WPF: https://www.mooict.com/wpf-c-tutorial-create-a-simple-quiz-game-in-visual-studio/
- Trivial Pursuit on Wikipedia: https://nl.wikipedia.org/wiki/Trivial_Pursuit


WPF Trivial Pursuit uitwerking 
Categorieën & Index
-	1: History
-	2: Arts & literature 
-	3: Sports & leisure
-	4: Science & nature
-	5: Geography 
-	6: Entertainment
Spel werking
1.	Om te beginnen krijg je een lijst van een leeg veld en een te kiezen kleur. Hier moet je minstens 2 en maximum 6 namen en kleuren invullen. Er kunnen geen 2 mensen dezelfde kleur hebben, iemand drukt op “volgende”.
a.	Speler gegevens worden in de databank opgeslagen.

2.	Eens het spel begonnen is wordt er een willekeurige persoon gekozen om te beginnen, zijn naam wordt getoond op het scherm. 

3.	Als de persoon wiens naam op het scherm getoond wordt op “gooi dobbelsteen” klikt, kiest het systeem automatisch een getal voor de speler (1-6) dat overeenkomt met de categorieën van de vragen. 

4.	Het scherm toont vervolgens bijbehorende vraag en 4 opties. Als je de juiste optie kiest, dan ontvang je – als je deze categorie nog niet hebt – een taartstukje van de bijbehorende kleur.
a.	Er wordt een vraag opgehaald uit de databank waarvan de index overeenkomt met de uitkomst van de dobbelsteen

5.	Het systeem toont een grafische weergave van de user zijn taartje momenteel als overzicht, daarna toont het systeem de naam van de volgende speler die aan de beurt is.
a.	Er wordt uit de databank opgehaald welke kleuren de huidige speler al dan niet  reeds bezit.

6.	Eens een speler al zijn taartjes gevuld heeft, wordt hij uitgeroepen als winnaar op het scherm.
Databank

