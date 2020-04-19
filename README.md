# TestyWSelenium
Czyli najlepsze testy! 
 
Login arrakisbse@gmail.com 
Hasło Selenium1

Technologie

    Selenium WebDriver
    C#
    NUnit

**************************
W skład repozytorium wchodzi 5 testów

każdy test rozpoczyna w http://automationpractice.com/index.php?controller=authentication&back=my-account
**************************
1.Add_To_Cart_After_Select_Item_Logged

Test rozpoczyna sie od zalogowania. Następnie przechodzi do strony głównej gdzie wybiera artykuł i jest przenoszony do podstrony z szczegółami. JEst zmieniony Rozmiar ubrania i dodanie do koszyka. Test jest kończony na oknie wyboru przejscia do podsumowania a powrotu do zakupów
**************************
2.Add_To_Cart_From_Main_Page_Item_Logged


Test rozpoczyna sie od zalogowania. Następnie przechodzi do strony głównej gdzie wybiera artykuł i odrazu dokonuje zakupu.Test jest kończony na oknie wyboru przejscia do podsumowania a powrotu do zakupów
**************************
3.ExecuteProperLogin

Test zaczyna się na stronie startowej /Signin. Następnie pola mail i hasło są uzupełniane i potwierdzone przyciskiem. Sprawdzenie czy zalogowano pomyślnie jest sprawdzenie czy jest widoczny element "my-account" na stronie 
**************************
4.ExecuteWrongLogin

Test zaczyna się na stronie startowej /Signin. Następnie pola mail i hasło są uzupełniane złym adresem mail i potwierdzone przyciskiem. Sprawdzenie czy nie zalogowano pomyślnie jest sprawdzane czy jest widoczny element "alert" na stronie 
**************************
5.FillContactForm

**************************

Done by Dominik Biedrzycki / Arkadiusz Ruszel

