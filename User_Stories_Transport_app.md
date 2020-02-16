NAME: Konto użytkownika
ID: E2
DESC: Zakładanie konta i logowanie
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Niezalogowany Użytkownik, mogę założyć kotno użytkownika:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Panel zakładania konta jest dostępny po max dwóch kliknięciach, z każdego miejsca w Portalu 
      [] Konto można połączyć z kontem Google lub Facebook
      [] Użytownik musi podać dwukrotnie jednakowe hasło, odpowiednio długie i skomplikowane
      [] Jeden adres email może być powiązany tylko z jednym kontem
      [] Użytkownik może określić profil swojego konta (zleceniodawca i/lub wynajmujący)
      [] Wynajmujący może dodać dane i opis swojej firmy
  Jako Niezalogowany Użytkownik, po wyborze oferty mogę założyć konto użytkownika:
    ID: US1
    PRIORITY: 6
    NOTES: none
    STATUS: TODO
    AC:
      [] Po wybraniu oferty, Niezalogowany Użytkownik zostaje przekierowany na stronę zakładania konta
      [] Wyszukana oferta zostaje zablokowana i nie może zostać wybrana i wyszykana przez innych Użytkowników
      [] Po założeniu konta, Użytkownik zostaje od razu przekierowany do wyszukanej oferty
  Jako Niezalogowany Użytkownik, mogę zalogować się do Portalu:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Użytkownik loguje się podając swoj email i hasło
      [] Użytkownik ma możliwość zapamiętania hasła
      [] Na ekranie logowania dostępny jest regulamin serwisu
      [] Na ekranie logowania dostępny jest link do odzyskiwania hasła
      [] Po poprawnym logowaniu, Użytkownik jest przekierowywany na stronę główną Portalu
  Jako Zalogowany Użytkownik, mogę edytować dane swojego konta:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Użytkownik może zmienić swój email na inny, dotychczas nieprzypisany do żadnego aktywnego konta
      [] Użytkownik może zmienić swoje hasło, potwierdzając je podaniem starego i dwukrotnym podaniem nowego hasła
      [] Użytkownik może zmienić dane swojej firmy
      [] Użytkownik może zmienić typ swojego konta (zleceniodawca i/lub wynajmujący) 
NAME: Budowa Portalu
ID: E3
DESC: Lista stron, które może wyświetlić Użytkownik
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Użytkownik mogę nawigować po Portalu:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] Użytkownik może wyśwetlić swój profil
      [] Użytkownik może wyśwetlić ustawienia aplikacji
      [] Użytkownik może wyśwetlić powiadomienia z zamówień i aplikacji
      [] Użytkownik może włączyć czat 
      [] Użytkownik może wyświetlić panel Floty Wynajmującego
      [] Użytkownik może wyświetlić podsumowanie zamówień, kursów i opini na temat innego Użytkownika 
  Jako Zleceniodawca mogę nawigować po Portalu:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] W panelu wyszukiwania Zleceniodawca może znaleźć odpowiednie oferty
      [] W panelu Zleceń Zleceniodawca może sprawdzić listę zarezerwowanych i historycznych kursów
  Jako Wynajmujący mogę nawigować po Portalu:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] W panelu wyszukiwania Wynajmujący może przegladać oferty
      [] W panelu Floty Wynajmujący może spradzić listę swoich samochodów
      [] W panelu Zamówień Wynajmujący może sprawdzić listę wynajętych samochodów oraz historię zleceń
      [] W panelu Kierowców Wynajmujący może sprawdzić listę Kierowców 
NAME: Wyszukiwanie
ID: E1
DESC: Wyszukiwanie ofert wynajmu samochodu i ogłoszeń od Zleceniodawców
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Zleceniodawca mogę wyszukać ofertę wynajmu samochodu:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Wyszukiwarka jest dostępna dla zalogowanych i niezalogowanych Użytkowników 
      [] Wyszukiwarka jest dostępna po max dwóch kliknięciach, z każdego miejsca w Portalu 
      [] Dla Zalogowanych Użytkowników, którzy ustawili oferty jako obserwowane, wyświetlają się one pod panelem wyszukiwania jako proponowane
      [] W Wyszukiwarce Użytkownik określa czy chce szukać ogłoszeń od Zleceniodawców czy ofert od Wynajmujących
  Jako Zalogowany Użytkownik mogę zapisać ofertę jako obserwowana:
    ID: US4
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] Klikając na ikonę Użytkownik jest w stanie zapisać daną ofertę lub ogłoszenie jako obserwowane
      [] Lista obserwowanych ofert lub ogłoszeń jest dostępna z menu
      [] Jeśli obserwowana oferta lub ogłoszeń spełnia kryteria wyszukiwania, pojawia się w wynikach jako pierwsza
  Jako Użytkownik mogę przefiltrować wyniki wyszukiwania:
    ID: US2
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Użytkownik może zdefiniować minimalną/maksymalną cenę usługi
      [] Użytkownik może określić wielkość ładunku w kg/m3
      [] Użytkownik może wybrać, czy wynajmuje kierowcę
      [] Użytkownik może wskazać na mapie punkt startowy oraz docelowy
      [] Użytkownik może wprowadzić adres startowy oraz docelowy wpisując go ręcznie
      [] Użytkownik może wprowadzić datę początu i końca wynajmu
      [] Użytkownik może wybrać typ samochodu
      [] Użytkownik może określić typ płatności za wynajem 
  Jako Wynajmujący mogę wyszukać Ogłoszenia Zleceniodawców:
    ID: US1
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Wyszukiwarka jest dostępna dla zalogowanych Wynjmujących 
      [] Wyszukiwarka jest dostępna po max dwóch kliknięciach, z każdego miejsca w Portalu 
      [] Ogłoszenie można zapisać jako obserwowane
  Jako Wynajmujący mogę przefiltrować wyniki wyszukiwania:
    ID: US2
    PRIORITY: 1
    NOTES: none
    STATUS: TODO
    AC:
      [] Wynajmujący może zdefiniować minimalną/maksymalną cenę usługi z Ogłoszenia
      [] Wynajmujący może określić wielkość ładunku w kg/m3
      [] Wynajmujący może przefiltrować Ogłoszenia z opcją wynajmuje kierowcę
      [] Wynajmujący może wskazać na mapie punkt i określić promień przeszukiwania
      [] Wynajmujący może wprowadzić adres startowy i określić promień przeszukiwania
      [] Wynajmujący może wprowadzić datę początu i końca wynajmu
      [] Wynajmujący może wybrać typ samochodu
      [] Wynajmujący może określić typ płatności za wynajem 
NAME: Budowa Floty samochodów i lisy Kierowców
ID: E3
DESC: Dodawanie samochodów do swojej floty
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Wynajmujący mogę dodać smochód do swojej Floty:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] Wynajmujący może dodać nowy wpis lub skopiować inny istniejący
      [] Wynajmujący może musi podać markę samochodu z listy dostępnych marek lub dodać własną
      [] Wynajmujący może musi podać model samochodu z zawężonej wg. marek listy, lub dodać własną
      [] Wynajmujący może określić nazwę własną samochodu
      [] Wynajmujący może podać numer rejestracyjny samochodu
      [] Wynajmujący może określić rocznik samochodu
      [] Wynajmujący może wprowadzić opis samochodu
      [] Wynajmujący musi określić ładowność samochodu w kg/m3
      [] Wynajmujący może musi określić cenę za wynajem samochodu oraz warunki wynajmu
      [] Wynajmujący może dodać zdjęcie samochodu
      [] Wynajmujący może określić ile samochodów o takich samych parametrach posiada
  Jako Wynajmujący mogę edytować smochód w swojej Flocie:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] Wynajmujący może zmienić markę samochodu z listy dostępnych marek lub dodać własną
      [] Wynajmujący może zmienić model samochodu z zawężonej wg. marek listy, lub dodać własną
      [] Wynajmujący może zmienić nazwę własną samochodu
      [] Wynajmujący może zmienić numer rejestracyjny samochodu
      [] Wynajmujący może zmienić rocznik samochodu
      [] Wynajmujący może zmienić opis samochodu
      [] Wynajmujący musi zmienić ładowność samochodu w kg/m3
      [] Wynajmujący może zmienić cenę za wynajem samochodu oraz warunki wynajmu
      [] Wynajmujący może zmienić lub usunąć zdjęcia samochodu
      [] Wynajmujący może zmienić informację o tym, ile samochodów o takich samych parametrach posiada
  Jako Wynajmujący mogę usunąć smochód ze swojej Flocie:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] Wynajmujący może usunąć samochód ze swojej Floty
      [] Przed usunięciem Wynajmujący zostanie zapytany o to, czy jest pewny swojej decyzji
      [] Wynajmujący nie może usunąć samochodów, które są obecnie wynajęte
  Jako Wynajmujący mogę Dodać Kierowcę:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] Wynajmujący musi podać nazwę Kierowcy
      [] Wynajmujący może dodać numer telefonu do Kierowcy
      [] Wynajmujący musi określić cenę i sposób płatności za usługi Kierowcy
      [] Wynajmujący może przypisać Kierowcę do danego samochodu z Floty. 
NAME: Dodawanie ofert wynajmu i publikowanie ogłoszeń
ID: E3
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Wynajmujący mogę dodać Ofertę:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] 
  Jako Zleceniodawca mogę dodać Ogłoszenie:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] 
  Jako Użytkownik mogę ocenić Wynajmującego lub Zleceniodawcę:
    ID: US1
    PRIORITY: 5
    NOTES: none
    STATUS: TODO
    AC:
      [] 
NAME: Rezerwowanie samochodu
ID: E4
DESC: 
NOTES: none
STATUS: TODO
USER STORIES:
  Jako Zalogowany Użytkownik mogę zarezerwować samochód:
    ID: US5
    PRIORITY: 10
    NOTES: none
    STATUS: TODO
    AC:
      [] 
