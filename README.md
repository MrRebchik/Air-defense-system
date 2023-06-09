# Air-defense-system
This model represents an air defense system. The drone carrying a missile patrols the space and destroys targets in its sector
#
Симуляция модели ПВО. Беспилотник, несущий ракету, патрулирует пространство по заданному маршруту, обнаруживает цели в пределах видимости своего радара и уничтожает их в своем секторе
# Дрон
В модели используется дрон Tadiran. Он кружит вокруг заданной точки и просматривает воздушное пространство радаром.
![image](https://user-images.githubusercontent.com/38166546/226450073-aeed65ca-d33f-4966-909f-6d5e2fc10d60.png)
# Ракета
В момент обнаружения радаром цели, программа экстраполирует траекторию полета с помощью метода Эйлера и в момент, когда точка встречи ракеты и цели попадает в дальность полета ракеты, происходит пуск ракеты С-8.
![image](https://user-images.githubusercontent.com/38166546/226450943-188b696f-f699-4e8e-ab14-d48a105d865f.png)
В программе симулируется кинематика ракеты с учетом аэродинамики
# Цель
В роли цели выступает крылатая ракета AGM JASSM
![image](https://user-images.githubusercontent.com/38166546/226451403-ae5ce6ff-4f74-48f0-b731-43f66c9ec2b9.png)
Внутри ракеты размечены границы модулей, которые требуется вывести из строя осколками
 #
![image](https://user-images.githubusercontent.com/38166546/226451789-c9708236-08bf-4d09-bb7c-9e5af8501194.png)
# Взрыв
Зенитная ракета, выпущенная с беспилотника наводится на крылатую ракету противника. 
![image](https://user-images.githubusercontent.com/38166546/226453442-ba85681b-7984-4562-9c69-3ef56cd5011e.png)
При подлете на расстояние максимальной эффективности дейстивия осколков симулируется детонация. Моделируется разлет 200 осколков, каждый из них при попадании в любой из отсеков ракеты противника имеет веростность поразить или не поразить его.
#
![image](https://user-images.githubusercontent.com/38166546/226453624-e5d54db0-e0cc-42fd-ae14-109c06a53680.png)
#
![image](https://user-images.githubusercontent.com/38166546/226453809-1493975f-f15e-43eb-92c2-a86072baeaae.png)
#
Затем отображаются результаты поражения отсеков.

![image](https://user-images.githubusercontent.com/38166546/226455847-524fc8af-7260-4a2b-bd3a-d49ad4616fd1.png)
# Тактический режим
В программе также можно посмотреть траектории полета ракет с разных стартовых точек. Ракеты заменены условными символами, местоность изображена в виде карты, траектории зеленая и красная линии (зенитной ракеты и ракеты противника соответственно).
![image](https://user-images.githubusercontent.com/38166546/226455984-0e5ebba3-30c0-40b8-8f8f-7ec01382f94a.png)
![image](https://user-images.githubusercontent.com/38166546/226456093-aa1a0d37-f683-4bd5-b455-1ac870b8bcc9.png)
