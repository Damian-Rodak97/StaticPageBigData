# Raport JMeter

## Tworzenie testów obciążenia dla aplikacji RSS

**Cel:** utworzenie prostego testu wydajności opartego o protokół HTTP przy użyciu aplikacji JMeter.

## Krok po kroku

Po uruchomieniu JMeter należy dodać **Thread Group** (grupa wątków). Uzupełniamy ustawienia w następujący sposób:

![Jmeter2](https://user-images.githubusercontent.com/50496148/77461080-4f70bd80-6e02-11ea-8f60-1928dd3db100.png)

Prawym przyciskiem myszy klikamy na **Thread Group**. Wybieramy **Add** > **Sampler** > **HTTP Request**. W ustawieniach HTTP Request wypełniamy pola według poniższego przykładu:

![Jmeter3](https://user-images.githubusercontent.com/50496148/77461473-e5a4e380-6e02-11ea-93e8-314103fda03c.png)


Wybieramy **Test Plan** > **Add** > **Listener** > **Graph Results**. Dodatkowo można wybrać opcję **View Results in Table**. Uruchamiamy test klikając przycisk **Uruchom** na pasku narzędzi lub poprzez kombinację klawiszy Ctrl + R.

![Jmeter](https://user-images.githubusercontent.com/50496148/77461129-644d5100-6e02-11ea-889e-b7227be0b75c.png)

Przepustowość odpowiada za zdolność serwera do obsługi dużego obciążenia. Im wyższa przepustowość, tym lepsza wydajność serwera.

W tym teście przepustowość wynosi 599.865 na minutę. Oznacza to, że serwer aplikacji osadzonej na portalu Azure może obsłużyć 599.865 żądań na minutę.

Odchylenie pokazane jest kolorem czerwonym - wskazuje odchylenie od średniej. Im mniejszy, tym lepiej.
Odchylenie od średniej wynosi: 101
Średnia wynosi: 107
Mediana wynosi: 70
Czas opóźnienia dla żądania wynosi: maksymalnie do 1100
Okres próbny: maksymalnie do 1100

![Adnotacja 2020-03-24 204315](https://user-images.githubusercontent.com/50496148/77470049-5a324f00-6e10-11ea-9438-7c9e5297051f.png)

Poniższy graf wykazuję że dla 20 użykowników aplikacja nie sklauję się ponieważ przepustowość nie rośnie.

![Jmeter4](https://user-images.githubusercontent.com/50496148/77468677-366e0980-6e0e-11ea-9a75-765a81699356.png)

