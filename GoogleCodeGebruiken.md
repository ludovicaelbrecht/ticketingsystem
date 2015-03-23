# Lid worden #

Voor de diensten (version control system, bugtracker, wiki...) te gebruiken, moet ge lid zijn van dit project.
Daarvoor moet ge een google account hebben, als ge gmail hebt, hebt ge dat al.
Zonder gmail moet ge eerst een account aanmaken op https://www.google.com/accounts/NewAccount?hl=nl (das niet voor een gmail-adres, das gewoon een google account met uw huidig emailadres, yahoo of wat dan ook).

Laat iets weten als ge dat aangemaakt hebt (en met welk emailadres), dan voeg ik u toe als "owner".

# Wiki & bug tracker #
De wiki wijst zichzelf uit - voor markup uitleg op "show" klikken rechts van uw textarea, onder "wiki markup help".

De bug tracker vindt ge terug onder issues. Heb nog geen idee hoe handig dat al dan niet gaat zijn, maar hoogstwaarschijnlijk zullen we wel bugs tegenkomen die we niet direct kunnen oplossen, en best niet vergeten. Daarbij, nen bug sluiten geeft voldoening ;-)

# Version Control System (VCS) #
Voornaamste voordeel is dat we niet constant moeten mergen, als ge thuis/op KHM/... wijzigingen wilt maken, doet ge een "check out" van de broncode - dan krijgt ge de laatste versie. Na uw wijzigingen doet ge een "check in" (liefst met een uitleg over de veranderingen die ge gedaan hebt), zodat de merge automatisch gebeurd, en de volgende persoon die een checkout doet uw wijzigingen ook download.

Ander voordeel is dat als er opeens een bug verschijnt die er eerst ni was, ge een paar versies ("revisions") terug kunt gaan, zien waar de bug voor 't eerst verscheen, en dan de verschillen bekijken tussen de laatste versie zonder bug en de eerste met bug.

Als ge een vrij groot stuk code verandert en een tijd later merkt dat uw nieuwe oplossing toch ni werkt, kunt ge ook gemakkelijker de oude oplossing terug ophalen (zonder met backups of "versie 67" te werken, wat vrij vermoeiend wordt na 'n tijd). Met checkin of "commit" messages kunt ge ook snel zien welke versie de oude oplossing nog had.

## TortoiseSvn ##

http://tortoisesvn.tigris.org/

Bedoeling van tortoiseSvn is vooral om te integreren met windows explorer, zoals ge kunt zien op http://tortoisesvn.tigris.org/ExplorerIntegration.html#contextmenus

Dit eerst installeren: dit is nodig voor visual studio plugin (tenzij ge ankhSvn gebruikt).

**STAPPEN VOOR GEBRUIK:**

  * tortoiseSVN downloaden:
> > - 32bit OS: http://prdownloads.sourceforge.net/tortoisesvn/TortoiseSVN-1.4.5.10425-win32-svn-1.4.5.msi?download


> - 64bit OS: http://prdownloads.sourceforge.net/tortoisesvn/TortoiseSVN-1.4.5.10425-x64-svn-1.4.5.msi?download

  * tortoiseSVN installeren

  * ergens rechtsklikken in windows explorer-> tortoiseSvn -> settings
> > - in "general" tab: "use (underscore)svn instead of .svn directories" aanvinken


> - in tabblad "look and feel" bovenste item, "checkout..." aanvinken

  * naar c:\ gaan. (of d:, of wat dan ook, gewoon een root).
> > - nieuwe map aanmaken, bvb "repo" of "repository"


> - rechtsklikken op deze map, tortoiseSvn -> check out. check out URL, username & wachtwoord staan op http://code.google.com/p/ticketingsystem/source

## Visual Studio plugins ##
### AnkhSvn ###

Voor Visual Studio plugins (om gemakkelijk checkouts & checkins te doen) is AnkhSvn goed dacht ik (http://ankhsvn.tigris.org/)

AnkhSvn werkt wel met VS2005, maar _niet met VS2005 Express Edition (de gratis versie)_ omdat microsoft in zijn licentie heeft staan dat dat verboden is.

### TortoiseSvn ###

Er heeft iemand een plugin geschreven die tortoisesvn integreert met visual studio (o.a. 2005, en ook express). De installatie is iets moeilijker dan AnkhSvn, maar deze plugin is de enige die werkt met VS2005 Express.

Heb de uitleg en de nodige bestanden geupload op http://ticketingsystem.googlecode.com/svn/trunk/resources/svn-plugin/

## Locking ##

't is mogelijk om een bestand te locken, bvb als ge 't compleet gaat herschrijven en ge ni wilt dat iemand er dan zijn tijd aan verspilt, kan locken handig zijn. Maar als ge gewoon wat wijzigingen doet, is da echt ni nodig, integendeel. Als Kenny een checkout doet en clDatabase.class wijzigt, en dan Willem een checkout doet en clDatabase.class snel wijzigt en terug incheckt, en Kenny daarna zijn checkin wil doen, zal subversion merken dat Kenny werkte op [revision 6](https://code.google.com/p/ticketingsystem/source/detail?r=6) van clDatabase.class, en dat de recentste versie ondertussen [revision 7](https://code.google.com/p/ticketingsystem/source/detail?r=7) is. Subversion merkt dan zelf of de veranderingen conflicteren (dus als jullie toevallig exact dezelfde lijn gewijzigd hebben). Als er geen conflict is, doet subversion een merge van de twee versies. Als er een conflict is, krijgt kenny 't conflict te zien en kiest hij wat er gebeurd.