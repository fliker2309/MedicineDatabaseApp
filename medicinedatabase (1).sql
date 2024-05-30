-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Май 30 2024 г., 08:44
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `medicinedatabase`
--

-- --------------------------------------------------------

--
-- Структура таблицы `body_check`
--

CREATE TABLE `body_check` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `date_of_issue` date NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `group_fizkult` varchar(255) NOT NULL,
  `suitability` varchar(255) NOT NULL,
  `prichina` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `body_check`
--

INSERT INTO `body_check` (`id`, `card_id`, `date_of_issue`, `doctor_id`, `group_fizkult`, `suitability`, `prichina`) VALUES
(1, 15, '2024-05-10', 2, 'Первая', 'Годен', 'Уважительная'),
(2, 15, '2023-05-14', 1, 'Первая', 'Годен', 'Не уважительная'),
(3, 15, '2021-05-30', 1, 'Вторая', 'Не годен', 'Не уважительная'),
(5, 17, '2024-05-15', 2, 'Вторая', 'Не годен', '');

-- --------------------------------------------------------

--
-- Структура таблицы `certificates`
--

CREATE TABLE `certificates` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `date_of_issue` varchar(255) NOT NULL,
  `illness` varchar(255) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `health_status` varchar(255) NOT NULL,
  `conclusion` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `certificates`
--

INSERT INTO `certificates` (`id`, `card_id`, `date_of_issue`, `illness`, `doctor_id`, `health_status`, `conclusion`) VALUES
(1, 29, '1998-05-29 00:00:00', 'авыпав', 2, 'авпыв', 'ывапа'),
(2, 29, '1996-05-29 00:00:00', 'dfsgsfdgsfd', 2, 'fdsgsfd', 'hdfsghsfd'),
(3, 33, '2024-05-29 00:00:00', 'ывфпфывп', 1, 'выфаыв', ''),
(4, 29, '2024-05-29 00:00:00', 'dshsdfh', 1, 'fdsjsdfj', 'gfdjdgfj'),
(5, 15, '2024-05-15 00:00:00', 'Простуда', 1, 'Удовлетворительное', 'Годен к учебе'),
(7, 17, '2024-05-29 00:00:00', 'Насморк', 2, 'Удовлетворительное', 'Здоров'),
(9, 17, '2024-05-29 00:00:00', 'Простуда', 2, 'Плохое', 'Не годен'),
(10, 17, '2005-08-13 00:00:00', 'Насморк', 2, 'Удовлетворительное', 'Годен'),
(19, 15, '2022-05-11 00:00:00', 'Насморк', 2, 'Удовлетворительное', 'Годен к учебе'),
(18, 15, '2024-05-29 00:00:00', 'Кашель', 2, 'Плохое', 'Не годен к учебе'),
(16, 15, '2024-05-30 00:00:00', 'Воспаление легких', 1, 'Плохое', 'Не годен к учебе');

-- --------------------------------------------------------

--
-- Структура таблицы `doctors`
--

CREATE TABLE `doctors` (
  `id` int(11) NOT NULL,
  `surname` varchar(255) NOT NULL,
  `name` varchar(255) NOT NULL,
  `lastname` varchar(255) NOT NULL,
  `age` date NOT NULL,
  `job_title` varchar(255) NOT NULL,
  `qualification` varchar(255) NOT NULL,
  `work_experience` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `doctors`
--

INSERT INTO `doctors` (`id`, `surname`, `name`, `lastname`, `age`, `job_title`, `qualification`, `work_experience`) VALUES
(1, 'Иванов', 'Иван', 'Иванович', '2024-05-16', 'Доктор', 'Врач', '2024-05-16'),
(2, 'Тутко', 'Михаил', 'Петрович', '1999-05-15', 'Врач', 'Педагог', '1990-05-27'),
(3, 'Шемис', 'Валентин', 'Тадеушевич', '1968-05-12', 'Хирург', 'Доцент', '2020-05-30'),
(4, 'Габуля', 'Иван', 'Сергеевич', '1970-05-12', 'Терапевт', 'Бакалавр', '2023-05-30'),
(5, 'Капчик', 'Евгений', 'Серггеевич', '1998-05-30', 'Лор', 'Врач', '2019-05-30');

-- --------------------------------------------------------

--
-- Структура таблицы `faculties`
--

CREATE TABLE `faculties` (
  `id` int(11) NOT NULL,
  `faculty` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `faculties`
--

INSERT INTO `faculties` (`id`, `faculty`) VALUES
(1, 'Информационных технологий'),
(2, 'Инженерно-строительный'),
(12, 'Факультет географии и геоинформатики'),
(11, 'Строитель'),
(13, 'Факультет журналистики'),
(14, 'Факультет прикладной математики и информатики'),
(15, 'Факультет радиофизики и компьютерных технологий'),
(16, 'Биологический факультет');

-- --------------------------------------------------------

--
-- Структура таблицы `health_visits`
--

CREATE TABLE `health_visits` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `complaints` varchar(255) NOT NULL,
  `symptoms` varchar(255) NOT NULL,
  `body_temperature` varchar(255) NOT NULL,
  `body_pressure` varchar(255) NOT NULL,
  `diagnos` varchar(255) NOT NULL,
  `recommendations` varchar(255) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `visit_date` date NOT NULL,
  `surgical_intervention` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `health_visits`
--

INSERT INTO `health_visits` (`id`, `card_id`, `complaints`, `symptoms`, `body_temperature`, `body_pressure`, `diagnos`, `recommendations`, `doctor_id`, `visit_date`, `surgical_intervention`) VALUES
(1, 15, 'Болит голова', 'Белое лицо', '36,7', '120/80', 'Переутомление', 'Отдых', 1, '2024-05-29', 'Нет'),
(2, 15, 'Высыпания на теле', 'Красные пятна', '38,8', '130/90', 'Алергея', 'Выпить таблетки диазолина', 2, '2023-05-29', 'Да'),
(3, 15, 'Болит нога', 'Порез ноги', '36,7', '120/90', 'Разрез ноги острым предметом', 'Наложена повязка', 2, '2024-05-30', 'Да'),
(6, 17, 'Боль в висках', 'Сыпь на лице', '37,7', '140/100', 'Алергея', 'Выпить таблетку Диазолина', 2, '2024-05-30', 'Нет');

-- --------------------------------------------------------

--
-- Структура таблицы `medicalcards`
--

CREATE TABLE `medicalcards` (
  `card_id` int(11) UNSIGNED NOT NULL,
  `student_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `medicalcards`
--

INSERT INTO `medicalcards` (`card_id`, `student_id`) VALUES
(12, 26),
(13, 27),
(14, 28),
(15, 29),
(16, 30),
(17, 31),
(18, 32),
(19, 33),
(20, 34);

-- --------------------------------------------------------

--
-- Структура таблицы `sick_leave`
--

CREATE TABLE `sick_leave` (
  `id` int(11) NOT NULL,
  `sick_number` varchar(255) NOT NULL,
  `sick_type` varchar(255) NOT NULL,
  `sick_start` date NOT NULL,
  `sick_end` date NOT NULL,
  `card_id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `sick_leave`
--

INSERT INTO `sick_leave` (`id`, `sick_number`, `sick_type`, `sick_start`, `sick_end`, `card_id`, `doctor_id`) VALUES
(2, '1234567', 'Грип', '2024-05-10', '2024-05-30', 15, 2),
(3, '123', 'Простуда', '2024-05-20', '2024-05-30', 15, 5),
(5, 'КН2943562', 'КН2943562', '2024-05-13', '2024-05-30', 17, 2);

-- --------------------------------------------------------

--
-- Структура таблицы `specialities`
--

CREATE TABLE `specialities` (
  `id` int(11) NOT NULL,
  `speciality` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `specialities`
--

INSERT INTO `specialities` (`id`, `speciality`) VALUES
(1, 'Графический дизайн и мультимедиадизайн'),
(2, 'Дизайн предметно-пространственной среды'),
(3, 'Архитектура'),
(4, 'Программное обеспечение информационных технологий'),
(10, 'Инженер-программист'),
(11, 'Инженер-энергетик'),
(12, 'Юрист'),
(13, 'Бухгалтер');

-- --------------------------------------------------------

--
-- Структура таблицы `students`
--

CREATE TABLE `students` (
  `id` int(11) NOT NULL,
  `surname` varchar(255) CHARACTER SET utf8 NOT NULL,
  `name` varchar(255) CHARACTER SET utf8 NOT NULL,
  `lastname` varchar(255) CHARACTER SET utf8 NOT NULL,
  `age` date NOT NULL,
  `sex` varchar(20) CHARACTER SET utf8 NOT NULL,
  `faculty_id` int(255) NOT NULL,
  `speciality_id` int(255) NOT NULL,
  `groupnumber` varchar(255) CHARACTER SET utf8 NOT NULL,
  `aducation_form` varchar(255) CHARACTER SET utf8 NOT NULL,
  `start_year` varchar(4) CHARACTER SET utf8 NOT NULL,
  `end_year` varchar(4) CHARACTER SET utf8 NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8mb4;

--
-- Дамп данных таблицы `students`
--

INSERT INTO `students` (`id`, `surname`, `name`, `lastname`, `age`, `sex`, `faculty_id`, `speciality_id`, `groupnumber`, `aducation_form`, `start_year`, `end_year`) VALUES
(34, 'Киселевич', 'Денис', 'Викторович', '1996-05-29', 'Мужской', 1, 10, '21ИТзс', 'Заочное', '2021', '2025'),
(29, 'Шемис', 'Артур', 'Валентинович', '1997-05-17', 'Мужской', 1, 4, '21ИТзс', 'Заочное', '2021', '2025'),
(31, 'Курач', 'Станислав', 'Леонидович', '1998-02-06', 'Женский', 1, 1, '20ИТзс', 'Заочное', '2020', '2024');

-- --------------------------------------------------------

--
-- Структура таблицы `vaccination`
--

CREATE TABLE `vaccination` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `vaccination_type` varchar(255) NOT NULL,
  `vaccination_date` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `vaccination`
--

INSERT INTO `vaccination` (`id`, `card_id`, `vaccination_type`, `vaccination_date`) VALUES
(1, 8, 'Корь', '2024-05-17'),
(2, 15, 'От гриппа', '2022-05-28'),
(3, 15, 'От столбняка', '2021-11-22'),
(4, 17, 'От гриппа', '2020-05-28'),
(7, 15, 'От простуды', '2023-05-17'),
(6, 18, 'цкуцку', '2222-05-29');

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `body_check`
--
ALTER TABLE `body_check`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `certificates`
--
ALTER TABLE `certificates`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `faculties`
--
ALTER TABLE `faculties`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `health_visits`
--
ALTER TABLE `health_visits`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `medicalcards`
--
ALTER TABLE `medicalcards`
  ADD PRIMARY KEY (`card_id`),
  ADD KEY `fk_student` (`student_id`);

--
-- Индексы таблицы `sick_leave`
--
ALTER TABLE `sick_leave`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `specialities`
--
ALTER TABLE `specialities`
  ADD PRIMARY KEY (`id`);

--
-- Индексы таблицы `students`
--
ALTER TABLE `students`
  ADD UNIQUE KEY `id` (`id`);

--
-- Индексы таблицы `vaccination`
--
ALTER TABLE `vaccination`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT для сохранённых таблиц
--

--
-- AUTO_INCREMENT для таблицы `body_check`
--
ALTER TABLE `body_check`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `certificates`
--
ALTER TABLE `certificates`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=20;

--
-- AUTO_INCREMENT для таблицы `doctors`
--
ALTER TABLE `doctors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `faculties`
--
ALTER TABLE `faculties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT для таблицы `health_visits`
--
ALTER TABLE `health_visits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT для таблицы `medicalcards`
--
ALTER TABLE `medicalcards`
  MODIFY `card_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=21;

--
-- AUTO_INCREMENT для таблицы `sick_leave`
--
ALTER TABLE `sick_leave`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT для таблицы `specialities`
--
ALTER TABLE `specialities`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=14;

--
-- AUTO_INCREMENT для таблицы `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=35;

--
-- AUTO_INCREMENT для таблицы `vaccination`
--
ALTER TABLE `vaccination`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=8;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
