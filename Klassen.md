## Conventies ##
> namen van klassen beginnen altijd me 'cl' gevolgd door een hoofdletter bijv.: clTicket


## Overzicht ##

**clAccessCon** : DBconnectieklasse naar Access DB

> _functies_: f\_getUserData,f\_checkLogin

**clSqlCon**    : DBconnectieklasse naar SQL Server (of oracle voorlopig)

> _functies_:f\_checkLogin(select),f\_toonKlant(select),f\_toonTicket(select),
> > f\_toonProductie(select),
> > f\_reserveerTicket(insert),f\_maakProductie(insert),f\_maakKlant(insert)

**clTicket**   : klasse voor beheer van een ticket


> _functies_: f\_ticReserveren, f\_ticWijzigen, f\_ticBekijken


**clProductie**: klasse voor beheer van producties

> _functies_: f\_prodToevoegen, f\_prodWijzigen,f\_prodBekijken


**clKlant**    : klasse voor beheer van klanten

> _functies_: f\_klantToevoegen, f\_klantWijzigen,f\_klantBekijken