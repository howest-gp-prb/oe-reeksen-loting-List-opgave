oe-reeksen-arrays-collections-loting-start
# Gebruik van List: Loting
In deze oefening simuleren we een loting van ploegen in een competitie. 

De bedoeling is dat elk van de ploegen een match speelt tegen een andere ploeg.

De ploegen die nog niet geloot zijn worden bijgehouden in de List<string> ploegenBeschikbaar.

De ploegen die geloot zijn worden bijgehouden in de List<string> ploegenGeloot.
  
![image01](https://github.com/howest-gp-prb/oe-reeksen-loting-List-opgave/blob/master/images/image01.gif?raw=true)

## Ploegen tonen

- ploegenBeschikbaar wordt getoond in lstBeschikbaar
- ploegenGeloot wordt getoond in lstGekozen
## Loting
De loting gebeurt door 2 willekeurige ploegen te kiezen uit de beschikbare ploegen.

Eens ze gekozen zijn, wordt deze match toegevoegd aan de lstMatchen.

De gekozen ploegen worden verwijderd uit ploegenBeschikbaar en toegevoegd aan ploegenGeloot.

De listboxen met de ploegen worden na elke loting aangepast.

## Einde loting
Eens alle ploegen geloot zijn, wordt de btnLoot uitgeschakeld.

## Opdracht
- Programmeer de bovenstaande functionaliteiten zo efficiënt mogelijk, met gebruikmaking van methodes. 
  - Volg het afgesproken stramien binnen de event handler methods:
  - Declaratie van lokale variabelen
  - Inlezen van de input van de gebruiker
  - Toewijzen van waarden aan de variabelen (indien eenvoudig statement)
  - Call(s) naar eigen methoden
  - Feedback naar de gebruiker


