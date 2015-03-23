# Todo #

## ASP ##
  * ...
  * ...
## VB ##
  * ...
  * ...
## DB ##
### Permissions ###
Zijn permissions mogelijk? iets zoals dit (komt uit [freeseat](http://sf.net/projects/freeseat)):
```
GRANT USAGE ON *.* TO bookinguser@127.0.0.1 TO bookinguser@localhost;
GRANT SELECT ON ticketing.seats TO bookinguser@localhost;
GRANT SELECT,INSERT,UPDATE,DELETE ON ticketing.seat_locks TO bookinguser@localhost;
GRANT SELECT ON ticketing.price TO bookinguser@localhost;
GRANT SELECT ON ticketing.theatres TO bookinguser@localhost;
GRANT SELECT ON ticketing.shows TO bookinguser@localhost;
```
Op 't eerste zicht lijkt alles inserts nodig te hebben, buiten tblAccesslevel. DELETE's zijn op de meeste tabellen wrsch niet nodig.
### Discounts ###
Is het mogelijke verschillende discounts te krijgen (bvb: er vroeg bij zijn + percentage voor 10 jaar abonnee)? In dat geval hebben we een n:n-relatie ipv 1:n-relatie tussen tblDiscount & tblTicket.
### tblZaal ###
  * bevat de plaatsen van de zaal, dus geen "id\_zaal" maar "id\_plaats", dus wrsch eerder tblPlaats ipv tblZaal
  * een persoon verschillende plaatsen boeken, dit moet dan gekoppeld worden met een record uit tblTicket
# Done #

## ASP ##
  * ...
  * ...
## VB ##
  * ...
  * ...







