<h1>Air-defense-system </h1>
<p>This model represents an air defense system. The drone carrying a missile patrols the space and destroys targets in its sector.</p>
<p>Симуляция модели ПВО. Беспилотник, несущий ракету, патрулирует пространство по заданному маршруту, обнаруживает цели в пределах видимости своего радара и уничтожает их в своем секторе</p>
<h1> Дрон </h1>
В модели используется дрон Tadiran. Он кружит вокруг заданной точки и просматривает воздушное пространство радаром.
<img src="https://user-images.githubusercontent.com/38166546/226450073-aeed65ca-d33f-4966-909f-6d5e2fc10d60.png" align="center"/>
<h1> Ракета </h1>
<p>В момент обнаружения радаром цели, программа экстраполирует траекторию полета с помощью <a href="https://ru.wikipedia.org/wiki/Метод_Эйлера" target="_blank">метода Эйлера</a>  и в момент, когда точка встречи ракеты и цели попадает в дальность полета ракеты, происходит пуск ракеты С-8.</p>
<img src="https://user-images.githubusercontent.com/38166546/226450943-188b696f-f699-4e8e-ab14-d48a105d865f.png" align="center"/>  
В программе симулируется кинематика ракеты с учетом аэродинамики
<h1> Цель </h1>
В роли цели выступает крылатая ракета AGM JASSM
<img src="https://user-images.githubusercontent.com/38166546/226451403-ae5ce6ff-4f74-48f0-b731-43f66c9ec2b9.png" align="center"/>  
Внутри ракеты размечены границы модулей, которые требуется вывести из строя осколками
 
<img src="https://user-images.githubusercontent.com/38166546/226451789-c9708236-08bf-4d09-bb7c-9e5af8501194.png" align="center"/>  
<h1> Взрыв </h1>
Зенитная ракета, выпущенная с беспилотника наводится на крылатую ракету противника. 
<img src="https://user-images.githubusercontent.com/38166546/226453442-ba85681b-7984-4562-9c69-3ef56cd5011e.png" align="center"/>  
При подлете на расстояние максимальной эффективности дейстивия осколков симулируется детонация. Моделируется разлет 200 осколков, каждый из них при попадании в любой из отсеков ракеты противника имеет веростность поразить его.

<img src="https://user-images.githubusercontent.com/38166546/226453624-e5d54db0-e0cc-42fd-ae14-109c06a53680.png" align="center"/>  

<img src="https://user-images.githubusercontent.com/38166546/226453809-1493975f-f15e-43eb-92c2-a86072baeaae.png" align="center"/>  

Затем отображаются результаты поражения блоков.

<img src="https://user-images.githubusercontent.com/38166546/226455847-524fc8af-7260-4a2b-bd3a-d49ad4616fd1.png" align="center"/>  
<h1> Тактический режим </h1>
В программе также можно посмотреть траектории полета ракет с разных стартовых точек. Ракеты заменены условными символами, местоность изображена в виде карты, траектории зеленая и красная линии (зенитной ракеты и ракеты противника соответственно).  
<img src="https://user-images.githubusercontent.com/38166546/226455984-0e5ebba3-30c0-40b8-8f8f-7ec01382f94a.png" align="center"/>
<img src="https://user-images.githubusercontent.com/38166546/226456093-aa1a0d37-f683-4bd5-b455-1ac870b8bcc9.png" align="center"/>
