# Húsvét

Egy embert jellemeznek a következő adatai:

* neve: legalább 3 karakter hosszú
* születési dátuma: legyen a mai dátumnál korábbi
* életkor property: a születési dátumból és a mai dátumból számolódik
* konstruktor, ami beállítja az ember összes adatát
* konstruktor, ami csak a nevét kapja meg, a születési dátumát a mai napra állítja be

Egy locsolkodót (mint embert) jellemezzenek még a következő adatok:

* milyen típusú kölnije van: pacsuli, ibolyaillatú, Britney Spears stb.
* testtömege hány %-ának megfelelő alkoholt ivott már: 0 és 100 között, tört szám is lehet
* konstruktor, amibe beállítja a locsolkodó összes adatát
* konstruktor, ami a születési dátumot nem kapja meg, hanem a szülőosztály megfelelő konstruktorát hívja meg
* iszik metódus:
    * 2 paramétere van: az elfogyasztott ital mennyisége grammban (pl. 500) és az adott ital alkoholtartalma százalékban (pl. 4,8)
    * számolja ki, hogy hány gram alkohol van ténylegesen az italban
    * ossza be 500-zal, majd ezzel növelje meg az előző mezőt

    * vállalhatatlan részegség property-je: logikai érték, mely igaz, ha az alkoholszázalék eléri a 40-et

A kocsmában húsvétkor összegyűlnek az emberek, azaz nyilvántartjuk a kocsmában összegyűlt emberek listáját.

* Írj property-t, mely visszaadja a kocsmában összegyűlt locsolkodók számát!

* Írj metódust, mely visszaadja a kocsmából azokat az embereket, akiknek a paraméterként megadott típusú kölni van a zsebében!

Írj főprogramot, mely:

* Létrehoz egy kocsma példányt.

* Feltölti a kocsmát egy szöveges fájlból emberekkel (köztük locsolkodókkal is). A szöveges fájlt is Te rakd össze!

* Kiírja a képernyőre azoknak az embereknek az adatait, akiknek ibolyaillatú kölni van a zsebében (ehhez használd a kocsma megfelelő metódusát) és már vállalhatatlanul részegek (ehhez használd a locsolkodó megfelelő property-jét).
