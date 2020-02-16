NAME: Konto użytkownika
ID: E1
DESC: Zakładanie konta i logowanie
NOTES: none
STATUS: CONCIDER
USER STORIES:
  Jako Niezalogowany Użytkownik, mogę założyć kotno użytkownika:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
- [ ] Panel zakładania konta jest dostępny po max dwóch kliknięciach, z każdego miejsca w Portalu 
- [ ] Konto można połączyć z kontem Google lub Facebook
- [ ] Użytownik musi podać dwukrotnie jednakowe hasło, odpowiednio długie i skomplikowane
- [ ] Jeden adres email może być powiązany tylko z jednym kontem
- [ ] Użytkownik może określić profil swojego konta (zleceniodawca i/lub wynajmujący)
- [ ] Wynajmujący może dodać dane i opis swojej firmy
  Jako Niezalogowany Użytkownik, po wyborze oferty mogę założyć konto użytkownika:
    ID: US2
    PRIORITY: 6
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Po wybraniu oferty, Niezalogowany Użytkownik zostaje przekierowany na stronę zakładania konta
      - [ ] Wyszukana oferta zostaje zablokowana i nie może zostać wybrana i wyszukana przez innych Użytkowników
      - [ ] Po założeniu konta, Użytkownik zostaje od razu przekierowany do wyszukanej oferty
  Jako Niezalogowany Użytkownik, mogę zalogować się do Portalu:
    ID: US3
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Użytkownik loguje się podając swoj email i hasło
      - [ ] Użytkownik ma możliwość zapamiętania hasła
      - [ ] Na ekranie logowania dostępny jest regulamin serwisu
      - [ ] Na ekranie logowania dostępny jest link do odzyskiwania hasła
      - [ ] Po poprawnym logowaniu, Użytkownik jest przekierowywany na stronę główną Portalu
  Jako Zalogowany Użytkownik, mogę edytować dane swojego konta:
    ID: US4
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Użytkownik może zmienić swój email na inny, dotychczas nieprzypisany do żadnego aktywnego konta
      - [ ] Użytkownik może zmienić swoje hasło, potwierdzając je podaniem starego i dwukrotnym podaniem nowego hasła
      - [ ] Użytkownik może zmienić dane swojej firmy
      - [ ] Użytkownik może zmienić typ swojego konta (zleceniodawca i/lub wynajmujący) 
  Jako Zalogowany Użytkownik, mogę usunąć swoje konto:
    ID: US5
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Użytkownik może usunąć swoje konto z Portalu
      - [ ] Przed usunięciem konta Użytkownik musi podać hasło do Portalu
      - [ ] Po usunięciu konta, profil Użytkownika jest oznaczony jako usunięty, nie wyświetla się jego nazwa i adres
      - [ ] Nie można reaktywować usuniętego konta
NAME: Budowa Portalu
ID: E2
DESC: Lista stron, które może wyświetlić Użytkownik
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Użytkownik mogę nawigować po Portalu:
    ID: US1
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Użytkownik może wyświetlić swój profil
      - [ ] Użytkownik może wyświetlić ustawienia aplikacji
      - [ ] Użytkownik może wyświetlić powiadomienia z zamówień i aplikacji
      - [ ] Użytkownik może włączyć czat 
      - [ ] Użytkownik może wyświetlić panel Floty Wynajmującego
      - [ ] Użytkownik może wyświetlić podsumowanie Zamówień, Przejazdów i Opinii na temat innego Użytkownika 
      - [ ] Użytkownik może otworzyć kreator nowej oferty
  Jako Zleceniodawca mogę nawigować po Portalu:
    ID: US2
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] W panelu wyszukiwania Zleceniodawca może znaleźć odpowiednie oferty
      - [ ] W panelu Zleceń Zleceniodawca może sprawdzić listę zarezerwowanych i historycznych Przejazdów
      - [ ] W panelu Firmy Zleceniodawca może zawrzeć informacje o swojej działalności
  Jako Wynajmujący mogę nawigować po Portalu:
    ID: US3
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] W panelu wyszukiwania Wynajmujący może przeglądać Oferty
      - [ ] W panelu Floty Wynajmujący może sprawdzić listę swoich Samochodów
      - [ ] W panelu Zamówień Wynajmujący może sprawdzić listę wynajętych Samochodów oraz historię zleceń
      - [ ] W panelu Kierowców Wynajmujący może sprawdzić listę Kierowców 
NAME: Wyszukiwanie
ID: E3
DESC: Wyszukiwanie ofert wynajmu Samochodu i Ogłoszeń od Zleceniodawców
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Zleceniodawca mogę wyszukać ofertę wynajmu Samochodu:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wyszukiwarka jest dostępna dla zalogowanych i niezalogowanych Użytkowników 
      - [ ] Wyszukiwarka jest dostępna po max dwóch kliknięciach, z każdego miejsca w Portalu 
      - [ ] Dla Zalogowanych Użytkowników, którzy ustawili oferty jako obserwowane, wyświetlają się one pod panelem wyszukiwania jako proponowane
      - [ ] W Wyszukiwarce Użytkownik określa czy chce szukać ogłoszeń od Zleceniodawców czy ofert od Wynajmujących
  Jako Zalogowany Użytkownik mogę zapisać ofertę jako obserwowana:
    ID: US2
    PRIORITY: 5
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Klikając na ikonę Użytkownik jest w stanie zapisać daną ofertę lub ogłoszenie jako obserwowane
      - [ ] Lista obserwowanych ofert lub ogłoszeń jest dostępna z menu
      - [ ] Jeśli obserwowana oferta lub ogłoszeń spełnia kryteria wyszukiwania, pojawia się w wynikach jako pierwsza
  Jako Użytkownik mogę przefiltrować wyniki wyszukiwania:
    ID: US3
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Użytkownik może zdefiniować minimalną/maksymalną cenę usługi
      - [ ] Użytkownik może określić wielkość ładunku w kg/m3
      - [ ] Użytkownik może wybrać, czy wynajmuje kierowcę
      - [ ] Użytkownik może wskazać na mapie punkt startowy oraz docelowy
      - [ ] Użytkownik może wprowadzić adres startowy oraz docelowy wpisując go ręcznie
      - [ ] Użytkownik może wprowadzić datę początku i końca wynajmu
      - [ ] Użytkownik może wybrać typ Samochodu
      - [ ] Użytkownik może określić typ płatności za wynajem 
      - [ ] Użytkownik może określić minimalną Ocenę Użytkownika publikującego Ogłoszenie
  Jako Wynajmujący mogę wyszukać Ogłoszenia Zleceniodawców:
    ID: US4
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wyszukiwarka jest dostępna dla zalogowanych Wynjmujących 
      - [ ] Wyszukiwarka jest dostępna po max dwóch kliknięciach, z każdego miejsca w Portalu 
      - [ ] Ogłoszenie można zapisać jako obserwowane
  Jako Wynajmujący mogę przefiltrować wyniki wyszukiwania:
    ID: US5
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może zdefiniować minimalną/maksymalną cenę usługi z Ogłoszenia
      - [ ] Wynajmujący może określić wielkość ładunku w kg/m3
      - [ ] Wynajmujący może przefiltrować Ogłoszenia z opcją wynajmuje kierowcę
      - [ ] Wynajmujący może wskazać na mapie punkt i określić promień przeszukiwania
      - [ ] Wynajmujący może wprowadzić adres startowy i określić promień przeszukiwania
      - [ ] Wynajmujący może wprowadzić datę początku i końca wynajmu
      - [ ] Wynajmujący może wybrać typ Samochodu
      - [ ] Wynajmujący może określić typ płatności za wynajem 
NAME: Budowa Floty Samochodów i listy Kierowców
ID: E4
DESC: Dodawanie Samochodów do swojej floty
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Wynajmujący mogę dodać Samochód do swojej Floty:
    ID: US1
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może dodać nowy wpis lub skopiować inny istniejący
      - [ ] Wynajmujący może musi podać markę Samochodu z listy dostępnych marek lub dodać własną
      - [ ] Wynajmujący może musi podać model Samochodu z zawężonej wg. marek listy, lub dodać własną
      - [ ] Wynajmujący może określić nazwę własną Samochodu
      - [ ] Wynajmujący może podać numer rejestracyjny Samochodu
      - [ ] Wynajmujący może określić rocznik Samochodu
      - [ ] Wynajmujący może wprowadzić opis Samochodu
      - [ ] Wynajmujący musi określić ładowność Samochodu w kg/m3
      - [ ] Wynajmujący może musi określić cenę za wynajem Samochodu oraz warunki wynajmu
      - [ ] Wynajmujący może dodać zdjęcie Samochodu
      - [ ] Wynajmujący może określić ile Samochodu o takich samych parametrach posiada
  Jako Wynajmujący mogę edytować Samochód w swojej Flocie:
    ID: US2
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może zmienić markę Samochodu z listy dostępnych marek lub dodać własną
      - [ ] Wynajmujący może zmienić model Samochodu z zawężonej wg. marek listy, lub dodać własną
      - [ ] Wynajmujący może zmienić nazwę własną Samochodu
      - [ ] Wynajmujący może zmienić numer rejestracyjny Samochodu
      - [ ] Wynajmujący może zmienić rocznik Samochodu
      - [ ] Wynajmujący może zmienić opis Samochodu
      - [ ] Wynajmujący musi zmienić ładowność Samochodu w kg/m3
      - [ ] Wynajmujący może zmienić cenę za wynajem Samochodu oraz warunki wynajmu
      - [ ] Wynajmujący może zmienić lub usunąć zdjęcia Samochodu
      - [ ] Wynajmujący może zmienić informację o tym, ile Samochodów o takich samych parametrach posiada
  Jako Wynajmujący mogę usunąć Samochód ze swojej Flocie:
    ID: US3
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może usunąć Samochód ze swojej Floty
      - [ ] Przed usunięciem Wynajmujący zostanie zapytany o to, czy jest pewny swojej decyzji
      - [ ] Wynajmujący nie może usunąć Samochodów, które są obecnie wynajęte
  Jako Wynajmujący mogę dodać Kierowcę:
    ID: US4
    PRIORITY: 3
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Wynajmujący musi podać nazwę Kierowcy
      - [ ] Wynajmujący może dodać numer telefonu do Kierowcy
      - [ ] Wynajmujący musi określić cenę i sposób płatności za usługi Kierowcy
      - [ ] Wynajmujący może przypisać Kierowcę do danego Samochodu z Floty. 
  Jako Wynajmujący mogę usunąć Kierowcę:
    ID: US5
    PRIORITY: 4
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Wynajmujący może usunąć Kierowcę ze swojej listy Kierowców
      - [ ] Przed usunięciem Wynajmujący zostanie zapytany o to, czy jest pewny swojej decyzji
      - [ ] Wynajmujący nie może usunąć Kierowców, którzy są obecnie w wynajęci
NAME: Dodawanie ofert wynajmu i publikowanie ogłoszeń
ID: E5
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Wynajmujący mogę dodać Przejazd:
    ID: US1
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący musi określić punkt startu i końca kursu
      - [ ] Wynajmujący musi podać datę i godzinę startu kursu
      - [ ] Wynajmujący może dodać tytuł oferty
      - [ ] Wynajmujący musi wybrać Samochód z Floty, który wykona Przejazd
      - [ ] Wynajmujący może wybrać z listy Kierowcę, który wykona Przejazd
      - [ ] Wynajmujący musi podać minimalny próg ładowności Przejazdu
      - [ ] Wynajmujący musi podać inicjalną ładowność Samochodu
      - [ ] Wynajmujący może określić maksymalne parametry paczek (wymiary/waga)
      - [ ] Wynajmujący musi określić stawkę za Przejazd (inicjalna, za km, za usługi Kierowcy, inne)
      - [ ] Wynajmujący może określić status Przejazdu
  Jako Wynajmujący mogę edytować Przejazd:
    ID: US2
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może zmienić punkt startu i końca kursu, o ile Przejazd jest w statusie Zmieniany
      - [ ] Wynajmujący może zmienić cenę Przejazdu i metodę płatności, o ile Przejazd jest w statusie Zmieniany
      - [ ] Wynajmujący może zmienić datę Przejazdu, o ile Przejazd jest w statusie Zmieniany
      - [ ] Wynajmujący może zmienić tytuł Przejazdu
      - [ ] Wynajmujący może zmienić Samochód na inny, o ile spełnia wymogi ładunkowe aktualnie złożonych zamówień 
      - [ ] Wynajmujący może zmienić Kierowcę przypisanego do Przejazdu
      - [ ] Wynajmujący może zmienić parametry ładowności Samochodu, o ile nie naruszają one aktualnie złożonych zamówień
      - [ ] Wynajmujący może zmienić status Przejazdu 
  Jako Wynajmujący mogę usunąć Ofertę:
    ID: US3
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może usunąć Przejazd, o ile nie złożono na niego żadnego zamówienia lub ma status inny niż Anulowany lub Zmieniony
      - [ ] Przed usunięciem Wynajmujący zostanie zapytany o to, czy jest pewny swojej decyzji
  Jako Wynajmujący mogę zmienić status Oferty:
    ID: US4
    PRIORITY: 3
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Wybór statusu "Zbieranie ofert" oznacza, iż Przejazd nie jest potwierdzony, trwa rezerwacja zamówień
      - [ ] Wybór statusu "Potwierdzony" oznacza, iż Przejazd odbędzie się w zadanym terminie
      - [ ] Wybór statusu "Rozpoczęty" oznacza, iż Przejazd jest aktywny i właśnie trwa
      - [ ] Wybór statusu "Zakończony" oznacza, iż Przejazd został zakończony z sukcesem i jest archiwizowany
      - [ ] Wybór statusu "Zawieszony" oznacza, iż Przejazd zostaje oznaczony jako niepotwierdzony, może przesunąć się jego data
      - [ ] Wybór statusu "Anulowany" oznacza, iż Przejazd nie odbędzie się
      - [ ] Wybór statusu "Zmieniany" powoduje, iż możliwa jest edycja warunków Przejazdu (destynacji, daty, ceny). Na wejście do statusu muszą zgodzić się Zleceniodawcy, którzy zgłosili się do Przejazdu
      - [ ] Zmiana statusu jest potwierdzana przesłaniem powiadomienia do Wynajmującego i Zleceniodawców
      - [ ] Statusy mogą się zmieniać automatycznie (np. status "Zakończony" o ile nie ustawiono inaczej, a Przejazd dobiegł końca)
  Jako Wynajmujący mogę utworzyć Kurs:
    ID: US5
    PRIORITY: 3
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Kurs jest drogą prowadzącą ze startu do punktu zakończenia Przejazdu, odwiedzającym wszystkie punkty wyznaczone przez Zamawiających i Wynajmującego
      - [ ] Kurs może zostać wygenerowany automatycznie przez algorytm, który znajdzie najszybszą drogę między zadanymi punktami
      - [ ] Kurs może zostać utworzony ręcznie poprzez ułożenie kolejnych odwiedzanych punktów oraz dodanie własnych punktów
      - [ ] Dla każdego punktu na kursie może zostać określona godzina odwiedzenia
      - [ ] Wynajmujący widzi wszystkie punkty odbioru
      - [ ] Kurs może być utworzony tylko raz. Dla jednego Przejazdu dostępny jest tylko jeden Kurs
  Jako Wynajmujący mogę edytować Kurs:
    ID: US6
    PRIORITY: 3
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Wynajmujący może zmienić kolejność i godziny odwiedzenia punktów między miejscem startu i punktem końcowym
      - [ ] Zmiana Kursu jest potwierdzana wysłaniem potwierdzenia do Wynajmującego i Zamawiających 
  Jako Zamawiający mogę podejrzeć Kurs:
    ID: US7
    PRIORITY: 3
    NOTES: none
    STATUS: CONSIDER
    AC:
      - [ ] Zamawiający może zobaczyć Kurs na panelu Przejazdu
      - [ ] Zamawiający widzi tylko punkt startowy i końcowy Kursu oraz miejsce, do którego zamówił Samochód
      - [ ] Zamawiający nie widzi punktów odbioru innych Zamawiających w danym Przejeździe
      - [ ] Zamawiający może sprawdzić godzinę odwiedzenia punktu 
NAME: Publikowanie ogłoszeń przez Zleceniodawcę
ID: E6
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Zleceniodawca mogę dodać Ogłoszenie:
    ID: US1
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Zleceniodawca może wybrać usługę wynajmu na czas lub odbioru ładunku
      - [ ] Zleceniodawca musi określić punkt odbioru ładunku lub Samochodu
      - [ ] Zleceniodawca może określić punkt nadania ładunku albo czas wynajmu samochodu
      - [ ] Wybierając usługę na czas, Zleceniodawca musi określić w jakim terminie chce wynajmować Samochód
      - [ ] Wybierając usługę na czas, Zleceniodawca może określić czy chce wynająć Kierowcę
      - [ ] Wybierając usługę odbioru ładunku, Zleceniodawca musi określić, kiedy może nadać ładunek
      - [ ] Zleceniodawca musi określić wymiary i wagę ładunku
      - [ ] Jeśli ładunek jest niespecyficzny lub niebezpieczny, Zleceniodawca musi dodać informacje o charakterze ładunku do Ogłoszenia
  Jako Zleceniodawca mogę edytować Ogłoszenie:
    ID: US2
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Zleceniodawca może zmienić tyup usługi wynajmu
      - [ ] Zleceniodawca może zmienić punkt odbioru ładunku lub Samochodu. 
      - [ ] Zleceniodawca może zmienić punkt nadania ładunku. 
      - [ ] Zleceniodawca może zmienić czas wynajmu Samochodu
      - [ ] Zleceniodawca może zmienić termin wynajmu Samochodu.
      - [ ] Zleceniodawca może zmienić informację o potrzebie wynajmu Kierowcy
      - [ ] Zleceniodawca może zmienić czas odbioru od siebie ładunku
      - [ ] Zleceniodawca może zmienić parametry ładunku
      - [ ] Zleceniodawca może zmienić opis ładunku 
  Jako Zleceniodawca mogę usunąć Ogłoszenie:
    ID: US3
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Zleceniodawca może usunąć Ogłoszenie. 
      - [ ] Przed usunięciem Ogłoszenia, Zleceniodawca zostanie zapytany o to, czy jest pewien swojej decyzji
      - [ ] Usuniętego Ogłoszenia nie można reaktywować
      - [ ] Nie można usunąć Ogłoszenia, które zostało zaakceptowane przez Zamawiającego.
NAME: Rezerwowanie Przejazdu
ID: E7
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Zleceniodawca mogę zarezerwować Przejazd:
    ID: US1
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Po wyborze Przejazdu Zleceniodawca może dodać szczegóły umowy
      - [ ] W przypadku wynajmu czasowego Wynajmujący musi podać miejsce startu oraz czas wynajmu
      - [ ] W przypadku wynajmu czasowego Wynajmujący może wynająć dodatkowo Kierowcę
      - [ ] W przypadku wyboru usługi transportu ładunku Zleceniodawca musi wybrać punkt startu i wyładunku
      - [ ] W przypadku wyboru usługi transportu ładunku Zleceniodawca musi wybrać termin odbioru ładunku
      - [ ] Jeśli dostępnych jest kilka opcji, Zleceniodawca musi wybrać metodę płatności za usługę
      - [ ] Zleceniodawca może wybrać formę rozliczenia za Przejazd (rachunek/faktura)
      - [ ] Do momentu zatwierdzenia Przejazdu, Zleceniodawca może zmienić parametry swojego zamówienia
      - [ ] Zarezerwowanie Przejazdu skutkuje zmniejszeniem dostępnej ładowności Samochodu lub zablokowaniem go do wynajmu czasowego
  Jako Zleceniodawca mogę edytować zarezerwowany Przejazd:
    ID: US2
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Póki finalnie nie zatwierdzono Przejazdu, Zleceniodawca może wprowadzać zmiany w Zamówieniu
      - [ ] Zleceniodawca może zmienić czas wynajmu Samochodu
      - [ ] Zleceniodawca może zmienić datę Przejazdu 
      - [ ] Zleceniodawca może zmienić gabaryty i masę ładunku, o ile mieszczą się one w dostępnej ładowności Samochodu
      - [ ] Zleceniodawca może określić, czy potrzebuje wynająć Kierowcę
      - [ ] Zleceniodawca może zmienić opcję płatności spośród wybranych przez Wynajmującego
  Jako Zleceniodawca mogę anulować rezerwację Przejazu:
    ID: US3
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Póki finalnie nie zatwierdzono Przejazdu, Zleceniodawca może anulować Zamówienie Przejazdu
      - [ ] Zleceniodawca zostanie zapytany, czy jest pewien swojej decyzji 
      - [ ] Po anulowaniu Zamówienia, zmianie ulegają dostępna ładowność Samochodu
      - [ ] Po anulowaniu Zamówienia, Samochód jest odblokowany do kolejnych rezerwacji
NAME: Rezerwowanie Oferty
ID: E8
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Wynajmujący mogę zarezerwować do realizacji Ofertę Zleceniodawcy:
    ID: US1
    PRIORITY: 2
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może wybrać do realizacji Ofertę Zleceniodawcy
      - [ ] Jeśli nie podano konkretnego czasu rozpoczęcia usługi, Wynajmujący może określić własną propozycję, o ile znajduje się ona w zakresie zadanym przez Zleceniodawcę
      - [ ] Wynajmujący może wybrać Samochód z Floty, który obsłuży Zamówienie
      - [ ] Wynajmujący może wybrać Kierowcę z listy, który obsłuży Zamówienie
      - [ ] Rezerwując Ofertę tworzony jest automatycznie Przejazd. Wynajmujący może określić, czy ma on zostać opublikowany do dalszych rezerwacji. 
  Jako Wynajmujący mogę anulować realizację Ofertę Zleceniodawcy:
    ID: US2
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Wynajmujący może anulować zamówienie zgodnie z zasadami anulowania Przejazdu
NAME: Ocena Przejazdów i innych Użytkowników
ID: E9
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Użytkownik mogę ocenić Wynajmującego lub Zleceniodawcę:
    ID: US1
    PRIORITY: 3
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Po zakończeniu usługi, w panelu jej podsumowania pojawia się opcja Oceny 
      - [ ] Panel Oceny usługi jest widoczny w historii Przejazdów 2 tygodnie po jej dacie zakończenia
      - [ ] Ocena odbywa się poprzez wybór noty w skali od 1 do 5, gdzie 1 to najniższa, a 5 najwyższa Ocena
      - [ ] Brak Oceny nie jest określany jako ocena 0
      - [ ] Wynajmujący może ocenić Zleceniodawcę
      - [ ] Zleceniodawca może ocenić osobno Wynajmującego, Samochód i Kierowcę
      - [ ] Dopóki panel dodawania Oceny, dopóty jest możliwe edytowanie noty
  Jako Użytkownik mogę dodać od Oceny komentarz na temat Użytkownika lub usługi:
    ID: US2
    PRIORITY: 4
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Komentarze wystawione do Ocen usług są widoczne na liście pod ich Oceną 
      - [ ] Komentarze wystawione do Ocen Użytkowników są widoczne po wybraniu odpowiedniej opcji w profilu głównym Użytkownika
      - [ ] Komentarze nie mogą być usunięte przez Użytkownika
      - [ ] Komentarz może zostać zgłoszony przez Użytkownika do Moderatora 
      - [ ] Komentarz może zostać usunięty przez Moderatora jeśli został uznany za sprzeczny z regułami Portalu, jest zafałszowany lub jest wynikiem ataku na Użytkownika
  Jako Użytkownik mogę śledzić Oceny i komentarze innych Użytkowników:
    ID: US3
    PRIORITY: 4
    NOTES: none
    STATUS: TODO
    AC:
      - [ ] Ocena Użytkownika jest wyświetlana w jego Profilu głównym i jest widoczna dla wszystkich Użytkowników
      - [ ] Oceny nie można ukryć
      - [ ] Widoczne jest kilka ostatnich komentarzy
      - [ ] Pozostałe komentarze są dostępne po rozwinięciu listy
      - [ ] Użytkownik może zgłosić Komentarz, który został wystawiony jemu lub przypisanym doń Samochodom i Kierowcom
