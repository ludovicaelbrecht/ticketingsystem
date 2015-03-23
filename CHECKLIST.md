# AlLGEMEEN: #
## OO-programmeren ##
=> zeker 3lagen structuur gebruiken:
  1. INTERFACE LAYER (aspx en aspx.vb file!! --> controle:veld ingevuld, veld correct ingevuld vb geen tekst in datum veld)
  1. BUSINESS LAYER (vb clProductie,clKlant,clVoorstelling--> bevat functies die verwijzen naar functies in de clSqlCon + controle:vb. is deze klant ouder dan 23?)
  1. DATA LAYER (clSqlCon, de eigenlijk SQL statement, geen controle)

## To do ##
  * Alle update en inputvelden valideren
  * Zoekfuncties voor klanten, tickest en voorstellingen snel op te sporen
  * Lay-out verbeteren
  * Foutbehandeling (zie persoonlijke checklist)
  * Geheugen terug vrijgeven (obj=Nothing enzo)
  * Zaalplan module (op het einde !)

# KLASSEN: #
## Reserveringen door klanten ##
  * Via mail bevestigen dat men komt (ordernummer + querystring)
  * Klanten beheren met verschillende profielen
  * Klanten verdelen over zaal
  * Automatisch klantengegevens ophalen
  * Groepen kunnen optie nemen op tickets
  * Verschillende prijzen
  * Limiet van aantal tickets bestellen
  * Laatste week betalen aan kassa
  * Laatste dag kopen aan kassa

## Tickets ##
  * Tickets  afdrukken allemaal / per  reservering / blanco
  * Plaats toewijzen aan klant
  * Betalingen opvolgen
  * Tickets annuleren door medewerker
  * Zaalplan voor medewerker bekijken

## Voorstellingen ##
  * Voorstellingen annuleren
  * Extra voorstellingen toevoegen
  * Voorstelling/productie laten verlopen

## Klanten ##
  * Rapporten maken


# PERSOONLIJKE CHECKLIST #
## KENNY ##
  * Voorstellingen : controle op invoer uur (10 invullen geeft errors)
  * Insert productie : zichtbaar veld is nu int==> boolean van maken?+code toevoegen dat dit automatisch wordt ingevuld naargelang de datum
  * Confirmations na inserts toevoegen of foutcode (try catch)
  * Controle==> geen 2x dezelfde voorstelling per dag toevoegen op hetzelfde uur ofzo
  * SQL injections voorkomen (filterfuncties?)

## JEROEN ##
  * Reserveringen van klanten voort uitwerken
## LUDO ##
  * Klasse tickets verder uitwerken
## WILLEM ##
  * Medewerkers beheren + lay-out + samenzetten
## MORGAN ##