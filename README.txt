
Opis programu:
Program realizuje uproszczoną wersję problemu plecakowego. Pozwala na wygenerowanie zestawu przedmiotów o losowych wartościach i wagach, 
a następnie wybiera te, które maksymalizują łączną wartość, mieszcząc się w zadanej pojemności plecaka.
Program realizuje zadanie na ocenę 4.0.

Opis działania:

Program działa w trybie konsolowym. Użytkownik może ustawić następujące parametry:
- liczbę przedmiotów `n`
- pojemność plecaka
- ziarno losowości (`seed`) do wygenerowania danych

Dane są następnie analizowane, a wynik prezentowany w formie listy indeksów zapakowanych przedmiotów, ich łącznej wagi i łącznej wartości.

Opis klas:

- Item – klasa reprezentująca pojedynczy przedmiot:
  - value – wartość przedmiotu
  - weight – waga przedmiotu
  - index – oryginalny indeks przedmiotu (do identyfikacji)
  - CompareTo(Item) – metoda porównująca przedmioty na podstawie stosunku wartości do wagi
  - przeciążone operatory < i > – umożliwiają sortowanie
  - ToString() – zwraca czytelną reprezentację przedmiotu

- Problem – klasa zarządzająca listą przedmiotów i rozwiązywaniem problemu:
  - Problem(int n, int seed) – konstruktor generujący `n` przedmiotów z losowymi danymi
  - Solve(int capacity) – metoda rozwiązująca problem plecakowy przy danej pojemności
  - ToString() – zwraca listę wszystkich wygenerowanych przedmiotów

- Result – klasa przechowująca wynik działania algorytmu:
  - items – lista indeksów zapakowanych przedmiotów
  - total_weight – łączna waga spakowanych przedmiotów
  - total_value – łączna wartość spakowanych przedmiotów
  - ToString() – zwraca wynik w formacie tekstowym

Algorytm:

Algorytm oparty jest na metodzie zachłannej (ang. *greedy*), która:
1. Sortuje przedmioty malejąco według stosunku wartości do wagi.
2. Dodaje do plecaka kolejne przedmioty z listy, o ile ich waga nie przekracza dostępnej pojemności.

Testy jednostkowe:

Program zawiera zestaw testów jednostkowych napisanych przy użyciu frameworka MSTest.

Zakres testów obejmuje m.in.:
- Poprawność liczby wygenerowanych przedmiotów
- Poprawne sortowanie przedmiotów według stosunku wartości do wagi
- Poprawne działanie algorytmu przy zerowej pojemności (zwraca pusty wynik)
- Poprawność indeksów wynikowych (mieszczą się w zakresie)
- Zachowanie algorytmu przy różnych rozmiarach danych
- Sprawdzenie, czy wynikowe przedmioty mieszczą się w zadanej pojemności plecaka

Testy znajdują się w projekcie `TestProject1` w klasie `UnitTest`.

Przykładowy wynik działania programu:

no.: 0  v: 8 w: 4 [2000]
no.: 1  v: 5 w: 2 [2500]
no.: 2  v: 3 w: 3 [1000]
...

result: 1, 0
[w,v]=[6, 13]

gdzie [w,v] oznacza, że liczby z prawej to kolejno waga przedmiotów w plecaku orza ich wartość.