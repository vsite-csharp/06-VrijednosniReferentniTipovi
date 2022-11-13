VrijednosniReferentiTip
=======================

DeklaracijaInicijalizacija
--------------------------
Usporedba deklaracije i inicijalizacije objekata vrijednosnog, odnosno 
referentnog tipa.


Nasljeđivanje
-------------
Usporedba nasljeđivanja kod struktura i klasa.


Pridruživanje
-------------
Usporedba pridruživanja objekata vrijednosnog i referentnog tipa.


UtjecajGCa
----------
Prikaz kako inicijalizacija i dealokacija objekata vrijednosnog ili 
referentnog tipa utječe na skupljača smeća (Garbage Collector).


Zapakiravanje
-------------
Unutar petlje se jedan te isti objekt vrijednosnog tipa dodaje u
kolekciju. Pri tome se objekt preslikava na hrpu (proces zapakiravanja)
- stvara se više instanci od istog objekta.


Otpakiravanje
-------------
Prilikom otpakiravanja moramo napraviti pretvorbu (cast) u izvorni tip.
U protivnom će biti bačena iznimka InvalidCastException. Čak i ako 
naknadno želimo napraviti pretvorbu otpakiranog objekta, prvo trebamo
pretvoriti u izvorni tip, a tek potom u željeni tip.


GeneričkaLista
--------------
Kod generičke kolekcije nema zapakiravanja prilikom dodavanja 
vrijednosnih tipova odnosno otpakiravanja prilikom dohvaćanja!
(usporediti IL kod s prethodnim: nema naredbi box i unbox)
