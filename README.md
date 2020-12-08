# Pizzeria
## Andreea Nenciu och Tijana Ilić

### Laboration 3: Pizzerian

#### Introduktion och syfte
Målet är att testa på olika designmönster i praktiken. Att lära sig avgöra var de olika
designmönstren underlättar koden, samt se hur kod kan fungera i praktiken.

#### Uppgift
Systemet ska utvecklas testdrivet från grunden. Testerna ska täcka en rimlig mängd av
programmet för att underlätta för er.
Systemet kommer att användas för att hantera ordrar på en pizzeria. En order består av
pizzor, läsk och extra tillbehör på pizzan. En pizza innehåller ju ett antal standardtillbehör,
men det går också att lägga till ett eller flera tillbehör på pizzan. Det är möjligt att bara
beställa läsk, men det behövs en grundpizza för att få beställa extra tillbehör.
I programmet ska det användas minst tre stycken motiverade och korrekt implementerade
designpatterns. Dessa ska skrivas ned och motiveras i README.md i ert repo.

Systemet ska implementeras som ett REST-api eller Console-app där det ska vara möjligt
att i flera steg lägga till och ta bort produkter i en order för att sedan godkänna den. När
ordern är lagd så ska det komma tillbaka en lista på ingredienser, alla produkter och totalt
pris. Ordern kan därefter väljas att markeras som “färdig” eller “avbruten”. Det ska också gå
att få ut en lista på alla orderar som inte är färdiga eller avbrutna ännu.
Tänk er att systemet i framtiden ska integreras i kassasystemet (för att ta betalt),
lagersystemet (för att hålla koll på lagersaldo på ingredienser), samt att visa upp en orderkö
på en skärm i köket för pizzabagarna att veta vad de ska laga.

Menyn för restaurangen ser ut som följande:
● Margerita - Ost, tomatsås - 85kr
● Hawaii - Ost, tomatsås, skinka, ananas - 95kr
● Kebabpizza - Ost, tomatsås, kebab, champinjoner, lök, feferoni, isbergssallad, tomat
kebabsås - 105kr
● Quatro Stagioni - Ost, tomatsås, skinka, räkor, musslor, champinjoner, kronärtskocka
- 115kr
● Coca cola - 20kr
● Fanta - 20kr
● Sprite - 25kr
● Extra ingrediens - Skinka, ananas, champinjoner, lök, kebabsås - 10kr
● Extra ingrediens - Räkor, musslor, kronärtskocka - 15kr
● Extra ingrediens - Kebab, koriander - 20kr

#### Redovisning
Källkoden ska vara pushad till ett eget publikt repository på GitHub. Uppgiften ska
genomföras parvis och fullständiga namn ska finnas med i README.md i repots
main-branch (master). I README.md ska också en lista på de designpatterns ni använder
finnas med, samt en motivering varför ni valde just detta för att lösa problemet.
