# PatternRecognizer

Простая библиотека для реализации распознавания образов на основе нейронной сети. Позволяет создать проект для распознавания образов.  

![Демонстрация работы программы](https://user-images.githubusercontent.com/30974622/54749410-7be96c80-4be5-11e9-8b7c-49e2ddc18f6b.gif)

## Структура проекта 
```
|Source
|--PatternRecognizer 
|--PatternRecognizer.BL
|--NeuraNet
|Examples
|-- Data
|-- SmileyRecognizer
|-- DigitRecognizer
```

### Исходный код проекта
PatternRecognizer.BL реализует бизнес-логику приложения. Описывает интерфейсы для работы с нейронной сетью. Содержит обертку для работы с [NeuraNet](https://github.com/mpopdam/NeuraNet) от @mpopdam.

В PatternRecognizer реализован паттерн MVP. На основе этого проекта можно быстро создать winforms приложение для расспознования образов из изображения произвольного размера.


### Примеры
В Examles\Data находятся обучающие выборки для обучения нейронной сети и сохраненные обученные нейронные сети для образца.

SmileyRecognizer - распознавание смайликов из изображения размером 7х5 px.
DigitRecognizer - распознавание цифр из изображения размером 3x5 px.

## С чего начать

Копируем проект

```
git clone https://github.com/q2een/PatternRecognizer.git
```
Переходим в папку с проектом
```
cd PatternRecognizer
```
Инициализируем и обновляем подмодуль
```
git submodule init
```
```
git submodule update
```

### Решение ошибки с зависимостями 
Открыть проект в VS. ПКМ на ссылках для проекта NeuraNet - выбрать "Перенести packages.config в PackageReference". 

## Создание своего проекта WinForms
Создание своего проекта для распознавания образов из изображения состоит из следующих этапов:
1. Создание обучающей выборки
2. Создание класса, реализующего `IPatternMap<T>`
3. Создание наследника класса `RecognizerView`
4. Добавление/изменение запуска приложения в `Program.cs`

### Создание обучающей выборки
Изображение должно формироваться по следующим правилам:
* Вертикально - образы для распознавания.
* Горизонтально - различные варианты отображения образа.

Размер каждого образа одинаковый. В Examles\Data находятся примеры обучающей выборки
 
Пример (размер каждого образа: 7х5 px):
![Пример обучающей выборки](https://user-images.githubusercontent.com/30974622/54749484-bc48ea80-4be5-11e9-95f1-dbc1d994f0c6.png)

### Создание класса, реализующего `IPatternMap<T>` 
В данном классе должны быть реализованы методы для получения текстового представления паттерна или для получения индекса паттерна. В примере приведен класс `DigitMap` для распознавания образов цифр:  

```
    public class DigitMap: IPatternMap<Image>
    {
        public int PatternCount => 10;

        public int GetIndexByPatternText(string text) => int.Parse(text);

        public string GetPatternTextByIndex(int index) => index.ToString();

        public Image GetPatternObject(int index) => null;

        public Image GetPatternObject(string text) => null;
    }
```

### Создание наследника класса `RecognizerView`
RecognizerView содержит свойства, связанные с графическим отображением элементов управления: 
````
// Возвращает или задает коэффициент масштабирования области рисования.
protected virtual int DrawerMultiplier { get; set; }

// Возвращает или задает флаг, указывающий на существование графического представления образа. 
protected virtual bool IsGraphicsResultExists { get; set; }
````

Исходный код класса потомка - все, что необходимо для реализовать для получения рабочего приложения:
```
using PatternRecognizer;

namespace DigitRecognizer
{
    class MainForm: RecognizerView
    {
        public MainForm()
        {
            DrawerMultiplier = 80;
            IsGraphicsResultExists = false;
            Text = "Распознавание цифр";
        }
    }
}
```
### Добавление/изменение запуска приложения в `Program.cs`
Исходный код класса `Program`. Тут задается размер изображения образа. 
```
using PatternRecognizer;
using PatternRecognizer.BL.ImagePattern;
using PatternRecognizer.BL.Network;
using PatternRecognizer.BL.NeuraNet;
using System;
using System.Windows.Forms;

namespace DigitRecognizer
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var view = new MainForm();
            IMessageService msgService = new DialogMessageService();

            INeuralNetwork network = new NeuraNet();
            INetworkManager manager = new NeuraNetFileManager();

            var patternManager = new ImagePatternManager();
            
            // Размер изображения: 3x5px. DigitMap класс, реализующий IPatternMap<T>.           
            var pattern = new ImagePattern(3, 5, new DigitMap());

            var presenter = new RecognizerPresenter(view, msgService, network, manager, patternManager, pattern);

            Application.Run(view);
        }
    }
}
```

## Ссылки
- [NeuraNet](https://github.com/mpopdam/NeuraNet) - Реализация нейронной сети
- [Истинная реализация нейросети с нуля. Часть 2. Распознавание цифр](https://habr.com/ru/post/352632/) - Статья на хабре откуда взята обучающая выборка для проекта с распознованиями цифр.
