### Типы беспроводных сетей
* Самоорганизующиеся (ad-hoc)
* Сенсорные

# Инфраструктура беспроводных сетей
Стационарная инфраструктура:
* Сотовая связь
* Базовые станции общаются между собой по проводной и беспроводной связи.
* Мобильные общаются с базовыми по беспроводной связи.
* Мобильность за счёт переключения между базовыми станциями (хэновер и роуминг)

## Ограничения
* Стационарная инфраструктура отсутствует
* Развёртывание дорого
* Нет времени или возможности

## Воможные применения сетей без стационарной инфраструктуры
* Автоматизация на производстве
* Ликвидация аварий
* Связь между автомобилями
* Военные сети
* Поиск парковочных мест
* IoT

# Мобильные саморганизующиеся сети

## Самоорганизующиеся (ad-hoc) сети
**Без инфраструктуры. Используются возможности участников.**

## Проблемы
Некоторые вещи сделать сложнее без централизованной инфраструктуры.
* Отсутствие базовой станции
* Ограниченная дальность
* Мобильность участников
* Ограниченность источников энергии

## Самоорганизация вместо базовой сети.
* Участники должны сами организовать сеть.
* Самоорганизация реализуется:
  - На MAC уровне. Базовая станция не назначает частоты для передачи инфы, учсатники должны сами распределить их между собой.
  - В маршрутизации. Алгоритм поиска маршрута передачи информации.

# Ретрансляция при удалённости узлов.
Часто требуется связь с узлами за пределами дальности прямой связи, для чего используется ретрансляция.

# Адаптивные протоколы для работы с движущимися узлами.
Часто узлы перемещаются.
* Их перемещение изменяет связи с соседями, и это должно учитываться при расчёте маршрутов передачи данных.
* Трудно организовать поддержку большого количества узлов.

# Энергоэффективный режим работы для экономии заряда батареи.
Когда узлы запитаны от батарей важно экономить энергию.  
Важно увеличить время работы:
* Узлов
* Сети в целом

Идеи эффективных протоколов:
* Маршруты с многократными ретрансляциями с низким расходом энергии на каждую.
* Учитывать при расчёте маршрутов текущую ёмкость батарей.
При этом параметры оптимизации могут вступить в противоречие друг с другом.

# Беспроводные сенсорные сети (приложения)
## Общая инфа
Акцент на взаимодействии не с человеком, а с окружающей средой посредством сенсоров

## Примеры применения
* Температурная карта поверхности
* Микроклимат в помещениях
* Напряжения в зданиях после землетрясения
* Контроль утечки вредных веществ
* Обнаружение проникновения
* Контроль за внесением удобрений
* Дорожное движение
* Логистика

## Состав БСС
* Источнки. Считывание данных из окружающей среды и отправка.
* Собиратели.
* Исполнительные механизмы.

## Классификация вариантов применения
* Обнаружение событий
* Периодические изменения
* Аппроксимация функций
* Обнаружение достижения предельных значений
* Отслеживание

## Варианты размещения
* Случайное
* Упорядоченное
* Подвижные узлы

## Техническое обслуживание
* Необходимо ли, и осуществимо ли техническое обслуживание.

# Беспроводные сенсорные сети (требования, устройства)
## Специфические требования к БСС
* Характер эксплуатации
* Качество обслуживания
* Отказоустойчивость
* Время функционирования
* Масштабирование
* Адаптация к плотности размещения узлов
* Программируемость
* Удобство обслуживания

## Механизмы, необходимые для выполнения этих требований
* Много ретрансляций
* Энерэффективность
* Автоматическое конфигурирование
* Ориентация на данные
* Локализация функций сети
* Компромиссы между параметрами оптимизации

# Сравнение MANET и БСС
Общее:
* Самоорганизация
* Энергоэффективность
* Ретрансляция

Различия:

|                                 | MANET                                      | БСС                                     |
|---------------------------------|--------------------------------------------|-----------------------------------------|
|           Оборудование          | Дороже, мощнее, больше по затрату ресурсов |                                         |
| Специализация                   | Структура единобразна                      | Построение сильно зависит от назначения |
| Взаимодействие с внешней средой | Отсутствует                                | Суть                                    |
| Размерность                     |                                            | Обычно больше по размерам               |
| Энергопотребление               |                                            | Требования жёстче                       |
| Надёжность                      |                                            | Роль отдельного узла несущественна      |
| Ориентация                      | Узлы                                       | Данные                                  |
| Мобильность                     |                                            |                                         |

# Беспроводные промышленные сети (fieldbus)
Связь в режиме реального времени. Разработаны для обнаружения, измерения и управления.
Много общего, но есть и различия:

|                           | Fieldbus | БСС    |
|---------------------------|----------|--------|
| Размерность               |          | Больше |
| Работа в реальном времени | Да       | Нет    |

# Важные технологии для БСС
* Снижение стоимости
* Миниатюризация (в переделе умная пыль)
* Получение дополнительной энергии

# Заключение
* MANET и БСС -- перспективны.
* Есть общее и есть различия.