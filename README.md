# DDD-PubLish

Projekt demo dot. tematyki "Domain-driven design w praktyce" prowadzonej w ramach spotkań [dotNET Poznań](https://www.facebook.com/people/Dotnet-Poznań/100085125540184).

Spotkania:
1. 2022.10.19 - [link do spotkania](http://fb.me/e/2GrzZSnSi), [prezentacja](https://www.dropbox.com/s/14hhmgmkghz7h3f).
2. ????.??.?? - implementacja modelu domenowego

## Przypadek biznesowy - PubLish 😎
PubLish to poznański pub dla programistów i osób z branży IT, który prowadzi sprzedaż napojów 🍺🥃🍷🍸🍹 i przekąsek 🍿🥜🥗.

Pub posiada dwie sale i może pomieścić 100 osób: ogólną z barem (70 osób) oraz kameralną (30 osób), którą można wynająć do organizacji spotkań, wystąpień i koncertów. Jeżeli danego dnia sala prywatna nie jest wynajęta to jest ogólnie dostępna dla klientów.

Każdy może wynająć salę za pewną stałą kwotę. Jeżeli wydarzenie jest darmowe to sala kosztuje np. 300 zł, jeżeli wydarzenie jest płatne to sala kosztuje o 50% więcej.

Do pubu może wejść każdy, ale tylko osoby posiadające indywidualny kod QR (programiści i osoby z branży IT, weryfikowane przez pracownika) mogą otrzymać specjalną zniżkę na napoje i przekąski. Co 2n (n od 1 do 10) zamówienie klienta powiększany jest rabat o 2% na kolejne zamówienie (2zamówienie 5%, 4z 10%, 8z 15%, 16z 20%, 32z 25%, 64z 30%, 128z 35%, 256z 40%, 512z 45%, 1024z 50%).

Pub wypłaca pracownikom prowizję od jego sprzedaży i premiuje staż pracy. Co 1024 sprzedaż pracownik otrzymuje o 0,5% więcej prowizji od swojej sprzedaży. Za każdy pełny przepracowany rok pracy pracownik otrzymuje dodatkowo 0,5%. Pracownik może maksymalnie osiągnąć 10% premii.

Jeżeli pracownik wynajmie salę otrzymuje premię w wysokości stałej kwoty np. 50 zł (za wydarzenie darmowe) i 75 zł (za płatne).

PubLish chce z wyprzedzeniem zamawiać towary w zależności od prognoz, aby zapewnić optymalne zatowarowanie.

PubLish planuje rozwój działalności poprzez wprowadzenie nowych sal oraz planuje otworzyć działalność w nowych lokacjach.

Właściciel potrzebuje systemu IT, który dostarczy mu kompleksową obsługę biznesu: zarządzanie pubem, zatowarowanie, sprzedaż, system rezerwacji, naliczanie rabatów i premii, stronę intranetową dla pracowników, stronę internetową dla klientów.

### Projektowanie strategiczne

Dziedzina biznesowa PubLish: prowadzenie pubu (zarządzanie pubem, zatowarowanie, sprzedaż, system rezerwacji, naliczanie rabatów i premii, stronę intranetową dla pracowników, stronę internetową dla klientów)

Poddziedzina podstawowa:
* promocje i oferta dla programistów
* wypłacanie premii pracownikom

Poddziedzina ogólna:
* zarządzanie punktem gastronomicznym
* zatowarowanie
* sprzedaż
* system rezerwacji

Poddziedzina pomocnicza:
* strona intranetowa i internetowa
* przewidywanie dostaw (AI)

### Projektowanie strategiczne

#### Kontekst pracownika
Aktorzy:
* Pracownik
* Klient

Komendy:
* Sprzedaj towary
* Wynajmij salę klientowi
* Zweryfikuj klienta VIP

Agregat:
* Pracownik

Zdarzenia domenowe:
* Zrobił transakcję (sprzedał towary)
* Wynajął salę klientowi
* Naliczono premię/prowizję
* Zweryfikował klienta VIP

Zewnętrzne systemy:
* System magazynu/towarów
* System punktu sprzedaży
* System rezerwacji

#### Kontekst klienta VIP
Aktorzy:
* Klient

Komendy:
* Złóż zamówienie

Agregat:
* Klient

Zdarzenia:
* Utworzono klienta VIP
* Zrobił transakcję (zakupił towary)
* Osiągnął wyższą premię
