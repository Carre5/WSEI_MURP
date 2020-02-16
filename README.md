# WSEI_MURP
Move your pack

* User stories [US](/Documentation/User_Stories_Transport_app.yml)
* UML [UML](/Documentation/UML_class_chart.vsdx)

## Konkurencja:
### 1.	Platformy ogłoszeń
  *	OLX (stan 08.12.2019) – 591 ogłoszeń
    -	kontakt do wynajmującego
    -	podstawowe informacje odnośnie oferty
    -	zwykle brak informacji o cenie ie sposobie jej wyliczania
    -	zdjęcie przykłądowego samochodu
  *	Gumtree (stan 08.12.2019) – 119 ogłoszeń
    -	kontakt do wynajmującego
    -	podstawowe informacje odnośnie oferty
    -	oferty mocno pomieszane, wyszukiwarka wymaga doprecyzowania frazy
    -	zwykle brak informacji o cenie ie sposobie jej wyliczania
    -	zdjęcie przykłądowego samochodu
### 2.	GoShare
  *	portal i aplikacja mobilna przeznaczona zarówno dla osób poszukujących usług transportu oraz przedsiębiorców, którzy dysponująflotą samochodów dostawczych lub osób, które dorywczo wypożyczają swój samochód. 
  *	Działa tylko na terenie USA (nie obsługuje nawet Kanady)
  
![map](/Pictures/image1.png)
  
  *	Portal: https://www.goshare.co
    -	wymaga logowania do złożenia zamówienia/znale
    -	ciekawa szata graficzna, 
    -	pozwala za darmo wyestymować cenę przejazdu
    -	dodane linki do aplikacji mobilnych (iOs, Android)
    -	Strona w pełni responsywna i dostosowana do użądzeń mobilnych
  *	Aplikacja mobilna (Android) 
    -	rozdzielona na aplikację dla:
      *	klientów: ocena 4,4 w Sklep Play, ponad 50 tys pobrań (https://play.google.com/store/apps/details?id=co.goshare.customer&hl=en_US)
      *	wynajmujących: ocena 3,8 w Sklep Play, ponad 10 tys pobrań (https://play.google.com/store/apps/details?id=co.goshare.driverapp&hl=en_US)
    -	Aplikacje nieprzetestowane – są niedostępne poza USA
### 3.	Fetchit. https://www.gofetchit.ca
  *	Aplikacja mobilna do zamawiania usług przewozowych. 
  *	Na stronie internetowej można uzyskać podstawowe informacje odnośnie aplikacji, zarejestrować swoje konto (wynajmującego) i znaleźć linki do aplikacji mobilnych (iOs, Android).
  *	Aplikacje mobilne:
    -	Android: ocena 3,3 w Sklep Play, ponad 5 tys pobrań
    -	iOS: ocena 4+
    -	Aplikacje nieprzetestowane – są niedostępne poza USA
### 4.	Anyvan https://www.anyvan.com/
  *	Portal służący do wyszukiwania ofert przewoźników
  *	Brak aplikacji mobilnej
  *	Dostępny w Wielkiej Brytani, Irlandii Północnej, USA, Niemczech, Francji i Hiszpanii 
  *	Połączony z ebay’em – po dodaniu numeru przesyłki można wyestymować cenę swojego przewozu. Ponadto współdziała z Zoopla, Gumtree i Preloved
  *	Umożliwia zarejestrowanie się jako wynajmujący samochody (telefonicznie). Dla Wynajmujących dostępny jest panel zarzączania swojąflotą. 
  *	Rozszerzono usługi o wynajem powierzchni magazynowej
### 5.	CityBee https://www.citybee.pl/
  *	Aplikacja mobilna do rezerwowania samochodów dostawczych na czas. Za jej pomocą można znaleźć w danym mieście samochód dostawczy, otworzyć go i rozliczyć płatność za niego. Do rejestracji wymagane jest prawo jazdy kat. B. Umożliwa również wynajem samochodów do przewozu osób.
  *	Aplikacja mobilna:
    -	Android: ocena 4,3, pobrano ponad 100 tys razy. 
    -	iOS: ocena 3,6
  *	Na stronie internetowej podano przykładowe ceny wynajmu wraz z user stories, szczegółowy cennik zawarto m.in. w opisie aplikacji mobilnej. 
  *	Nie ma możliwości nawiązania współpracy jako wynajmujący
### 6.	AVIS https://www.avis.pl/
  *	Portal I aplikacja mobilna służąca do wynajmu samochodów. W ofercie są dostępne samochody dostawcze, osobowe oraz zastępcze. Oferuje również wynajem na pordóż tylko w jedną stronę, dodatkowe ubezpieczenia, wynajem samochodu wraz z kierowcą. Oferta dotyczy głównie samochodów osobowych. Auto można odebrać z punktów dostępnych w największych miastach oraz na lotniskach. 
  *	AVIS jest firmąmiędzynarodową, działąjącą w ok 5000 lokacji, w 165 krajach na całym świecie. 
  *	Nie ma możliwości zaoferować własnych usług za pośrednictwem portalu lub aplikacji mobilnej
  *	Aplikacja mobilna:
    -	Android: ocena 3,8, pobrano ponad 500 tys razy. 
    -	iOS: ocena 4,5

## Potencjalni klienci:

Określenie ilości potencjalnych klientów dla aplikacji nie jest proste z uwagi na to jak złożony jest rynek usług transportowych. Na rynku Polskim, w 2019  zarejestrowano niemal 70 tys nowych samochodów dostawczych o dopuszczalenj masie całkowitej (DMC) <= 3,5 t. W porównaniu do poprzedniego roku jest to o 1000 pojazdów więcej (wzrost o 1,5%). Szczegóły przedstawiono na Wykresie 2. Przedstawiono tam również podział na 15 najczęściej rejestrowanych marek w naszym kraju (stanowią niemal 98,5% wszystkich zarejestrowanych pojazdów). Struktura rynku według marek może być przdatna w celu rozwoju aplikacji o bazę danych samochodów dostawczych.
Najpopularniejszym modelem w tej kategorii jest Fiat Florino, następnie Renault Master i Iveco Daily. Szczegółowe dane przedstawiono w Tabeli 1.

![Table1](/Pictures/table1.png)

W Polsce, ilość samochodów dostawczych i ciężarowych stale wzrasta. Samochody ciężarowe i dostawcze stanowią ponad 12% wszystkich pojazdów jeżdżacych po naszych drogach. Szczegóły przedstawiono na Wykresie 1.  

![Chart1](/Pictures/chart1.png)
 
![Chart2](/Pictures/chart2.png)
 
W całej Unii Europejskiej, w 2016 roku zarejestrowano niemal 2mln lekkich samochodów dostawczych. Podział według krajów widać w tabeli 2. Duża różnica między danymi PZPM i EURF może wynikać ze zwiększenia się w Polsce nowych rejestracji (2016 vs. 2019) oraz innej metodologii badań. 

 
![Table2](/Pictures/table2.png)

LITERATURA
* "Park pojazdów zarejestrowanych w Polsce 1990-2017” z 16.07.2019, za Polski Związek Przemysłu Motoryzacyjnego (https://www.pzpm.org.pl)
* "Road statistics, yearbook 2017" European Union Road Federation
* “Transport - wyniki działalności w 2018 roku” – GUS, Warszawa, Szczecin 2019
* „PwC CEE Transport & Logistics Trend Book 2019” – M. Mazur, G. Urban i inni, PwC 2018
* “Road freight transport statistics” (https://ec.europa.eu/eurostat/statisticsexplained/) – Eurostat 2019
* “The Impacts of Globalisation on International Road and Rail Freight Transport activity” – A. Woodburn, J. Allen i inni, University of Westminster, Londyn 2008
* „ASP.NET 2.0. Projektowanie aplikacji internetowych” – R. Connolly, Helion 2008

