## Парсинг сайтов  

- вручную - цикл while  
- регулярки  
- библиотеки  
- запросы GET и POST   
- скачивание файлов  
- рассылка по email  

**Техническое задание**  

1) распарсить ТВ-программу и вывести в виде файла с разметкой markdown  
[время	название программы](ссылка на программу)"  
пример оформления приведён в файле shedule.md  
2) с сайта https://www.sports.ru/rfpl/table/ спарсить турнирную таблицу и сохранить в виде csv-файла и вывести на экран  

---  

_вариант курсового проекта:_  
- сделать WinForms  
- пусть будет список прокрутки: можно менять канал из списка (сами установите 5-6 каналов)  
- пусть будет календарь или просто список (в пределах +/- семи дней): можно менять дату для парсинга ТВ-программы  

---  

https://yandex.ru/pogoda/perm/month/march?via=cnav  
https://www.avito.ru/perm?q=vesta  
https://www.avito.ru/perm?q=vesta&p=2  
https://tv.yandex.ru/channel/rossiya-1-31?date=2020-03-15  

---  

``` html  
<div class="channel-header__title">
    <figure class="image image_size_l channel-logo channel-logo_size_l channel-header__logo">
    <img class="image__img" src="//avatars.mds.yandex.net/get-tv-channel-logos/69315/2a00000160080246940dc3516e9d4ce7d9b2/orig">
    </figure>
    <h1 class="channel-header__text">Россия 1</h1>
</div>
```

**docs HtmlAgilityPack**  
https://itvdn.com/ru/blog/article/using-html-agility-and-css-selectors  

---  