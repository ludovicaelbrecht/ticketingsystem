eerst SubversionInstall.vbs runnen. de versie hierbij heb ik aangepast zodat die met "Visual Studio Web Developer 2005 Express Edition" werkt, en zal dan ook alleen daarmee werken.
na 't runnen VS Wevdev opstarten -> menu "Tools" -> "import & export settings" -> next -> next -> browse -> SubversionMenuToolbarContextsVS2005.vssettings selecteren -> finish.

een menu "subversion" is toegevoegd.
sluit VS Webdev af, en open c:\repo\src\eticketing\eticketing.sln (ALLEEN ZO VS Webdev OPENEN!!! niet vanuit visual studio uw project openen). maak uw wijzigingen, voeg bestanden toe, enzovoort.
als ge werkende(!) wijzigingen hebt: subversion -> "commit" -> de toegevoegde / gewijzigde bestanden aanvinken als ze dat niet zijn (tenzij ge ze ni wilt committen), uw uitleg van de wijzigingen intikken, en committen.  efkes wachten, en op ok drukken.

belangrijk is van altijd eticketing.sln te openen, hier maakt hij anders een .sln & .suo aan in C:\Documents and Settings\user\My Documents\Visual Studio 2005\Projects\eticketing, waarna subversion een conflict krijgt omdat die map buiten de repo valt.