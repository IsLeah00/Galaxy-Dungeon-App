#                           Galaxy Dungeon

## 1.	Rendszerspecifikáció

### Feladat
A Dungeons of the Galaxy project olyan 2D dungeon crawl játék, amely a felhasználót fantasy szerepjátékba csábítja. Kezdetben a demo játék tartalmazza a játékos által irányított hőst, akit egy csapdákkal teli labirintusszerű pályán kell navigálnia, miközben szörnyekkel, azaz a szinten lévő ellenfelekkel küzd meg. A szórakozási élmény a későbbiekben local CO-OP lehetőséggel, három különböző megjelenésű, nehézségű pályával és feladatrendszerrel gazdagodik.

### Fejlesztői eszközök
Microsoft Visual Studio 2019, Blender, Paint 3D

### Környezet
Windows 10, C#, Unity Engine


## 2.	Követelményspecifikáció

### Jelenlegi helyzet leírása
	A mai modern világban az emberek napi szinten használják telefonjaikat, laptopjaikat vagy asztali számítógépeiket. Így a stressztől való elszakadást, kikapcsolódást nagyrészt ezeken az eszközökön végzik. A játékok nem csupán a szórakozásban segítenek, hanem hozzájárulnak a kéz-szem koordináció, problémamegoldó- és logikai készség, multitasking képesség fejlesztéséhez. Mindemellett könnyebben építhető szociális kapcsolat a CO-OP videójátékok világában.

### Vágyálom rendszer leírása
	Egy 2D-s local CO-OP dungeon crawl játék elkészítése. A felhasználó feladatok teljesítésével juthat újabb szintre. A feladatrendszer tartalmazza a különböző pályákhoz alkalmazkodó ellenfelekkel történő küzdelmet, amelyekből az első három pálya végén miniboss-okkal, a negyedik szinten pedig a fő boss-al küzdhet meg a user. Emellett néhány superboss (rejtett boss) is elhelyezésre került, amik megölése újabb kihívás elé állítja a játékost.

### Igényelt üzleti folyamatok
	Szórakozást biztosít minden 2D dungeon game iránt érdeklődő személynek. A local CO-OP lehetőség a kétszemélyes játékokat keresők igényeit is kiszolgálja, ezzel bővítve a felhasználók körét.

### Követelménylista
	Játékhoz alkalmas platform laptop vagy asztali számítógép. Ajánlott operációs rendszer Windows 10, de kompatibilis a Windows 7 és Windows 11 is. További minimális követelmények CPU – x86/x64 architektúra SSE2 utasításkészlet támogatással, GPU – legalább DX10-képes. Javasolt az adott hardvergyártó hivatalosan támogatott illesztőprogramjainak telepítése és/vagy frissítése. Eszköz követelménye az egér és billentyűzet egyaránt.


## 3.	Funkcionális specifikáció

### Program célkitűzése
	Szórakozás nyújtása az egyszemélyes és kétszemélyes 2D dungeon játékokat kedvelők számára. A felhasználó kizökkentése a mindennapi stressz helyzetekből egy egyedi játékélmény bemutatásával.
	A projectnek nem célja a user felesleges feszültségének fokozása, ennek elkerülésének érdekében a nehézségi szintek beállítása szolgál a nyugodt, pozitívabb impresszió keltésére.

### Tesztelés
	A Unity Engine által biztosított Test Runner végzi a Unity teszteket.

### Használat célja
	Mindennapokban szórakoztatás, barátokkal való időtöltés, unaloműzés vagy fizikai megterhelést nem igénylő kikapcsolódás.