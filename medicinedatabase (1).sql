-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Host: localhost:3306
-- Generation Time: May 23, 2024 at 07:18 PM
-- Server version: 5.7.24
-- PHP Version: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `medicinedatabase`
--

-- --------------------------------------------------------

--
-- Table structure for table `body_check`
--

CREATE TABLE `body_check` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `date_of_issue` varchar(255) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `group_fizkult` varchar(255) NOT NULL,
  `suitability` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `certificates`
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

-- --------------------------------------------------------

--
-- Table structure for table `doctors`
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
-- Dumping data for table `doctors`
--

INSERT INTO `doctors` (`id`, `surname`, `name`, `lastname`, `age`, `job_title`, `qualification`, `work_experience`) VALUES
(1, 'Иванов', 'Иван', 'Иванович', '2024-05-16', 'Доктор', 'Врач', '2024-05-16');

-- --------------------------------------------------------

--
-- Table structure for table `faculties`
--

CREATE TABLE `faculties` (
  `id` int(11) NOT NULL,
  `faculty` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `faculties`
--

INSERT INTO `faculties` (`id`, `faculty`) VALUES
(1, 'Информационных технологий'),
(2, 'Инженерно-строительный');

-- --------------------------------------------------------

--
-- Table structure for table `health_visits`
--

CREATE TABLE `health_visits` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `complaints` varchar(255) NOT NULL,
  `symptoms` varchar(255) NOT NULL,
  `body_temperature` varchar(4) NOT NULL,
  `body_pressure` varchar(11) NOT NULL,
  `diagnosis_id` int(11) NOT NULL,
  `recommendations` varchar(255) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `visit_date` varchar(11) NOT NULL,
  `surgical intervention` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `illness`
--

CREATE TABLE `illness` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `illness_type` varchar(255) NOT NULL,
  `illness_name` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `medicalcards`
--

CREATE TABLE `medicalcards` (
  `card_id` int(11) UNSIGNED NOT NULL,
  `student_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `medicalcards`
--

INSERT INTO `medicalcards` (`card_id`, `student_id`) VALUES
(12, 26),
(13, 27),
(14, 28),
(15, 29),
(16, 30);

-- --------------------------------------------------------

--
-- Table structure for table `sick_leave`
--

CREATE TABLE `sick_leave` (
  `id` int(11) NOT NULL,
  `sick_number` int(11) NOT NULL,
  `sick_type` varchar(255) NOT NULL,
  `sick_start` varchar(255) NOT NULL,
  `sick_end` varchar(255) NOT NULL,
  `card_id` int(11) NOT NULL,
  `doctor_id` int(11) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

-- --------------------------------------------------------

--
-- Table structure for table `specialities`
--

CREATE TABLE `specialities` (
  `id` int(11) NOT NULL,
  `speciality` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `specialities`
--

INSERT INTO `specialities` (`id`, `speciality`) VALUES
(1, 'Графический дизайн и мультимедиадизайн'),
(2, 'Дизайн предметно-пространственной среды'),
(3, 'Архитектура'),
(4, 'Программное обеспечение информационных технологий');

-- --------------------------------------------------------

--
-- Table structure for table `students`
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
-- Dumping data for table `students`
--

INSERT INTO `students` (`id`, `surname`, `name`, `lastname`, `age`, `sex`, `faculty_id`, `speciality_id`, `groupnumber`, `aducation_form`, `start_year`, `end_year`) VALUES
(19, 'Иванов', 'Иван', 'Иванович', '2024-05-23', 'Женский', 1, 1, '2', 'Заочное', '2021', '2025'),
(20, 'Фами', 'Имя', 'О', '2024-05-23', 'Мужской', 1, 1, 'цуц', 'Очное', '2021', '2027'),
(29, 'Шемис', 'Артур', 'Валентинович', '1997-05-17', 'Женский', 1, 4, '21ИТзс', 'Заочное', '2021', '2025');

-- --------------------------------------------------------

--
-- Table structure for table `vaccination`
--

CREATE TABLE `vaccination` (
  `id` int(11) NOT NULL,
  `card_id` int(11) NOT NULL,
  `vaccination_type` varchar(255) NOT NULL,
  `vaccination_date` date NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Dumping data for table `vaccination`
--

INSERT INTO `vaccination` (`id`, `card_id`, `vaccination_type`, `vaccination_date`) VALUES
(1, 8, 'Корь', '2024-05-17');

-- --------------------------------------------------------

--
-- Table structure for table `visit_certificate`
--

CREATE TABLE `visit_certificate` (
  `id` int(11) NOT NULL,
  `health_visit_id` int(11) NOT NULL,
  `certificate_date` varchar(11) NOT NULL,
  `illness` varchar(255) NOT NULL,
  `doctor_id` int(11) NOT NULL,
  `health_status` varchar(255) NOT NULL,
  `conclusion` varchar(255) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Indexes for dumped tables
--

--
-- Indexes for table `body_check`
--
ALTER TABLE `body_check`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `certificates`
--
ALTER TABLE `certificates`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `doctors`
--
ALTER TABLE `doctors`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `faculties`
--
ALTER TABLE `faculties`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `health_visits`
--
ALTER TABLE `health_visits`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `illness`
--
ALTER TABLE `illness`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `medicalcards`
--
ALTER TABLE `medicalcards`
  ADD PRIMARY KEY (`card_id`),
  ADD KEY `fk_student` (`student_id`);

--
-- Indexes for table `sick_leave`
--
ALTER TABLE `sick_leave`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `specialities`
--
ALTER TABLE `specialities`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `students`
--
ALTER TABLE `students`
  ADD UNIQUE KEY `id` (`id`);

--
-- Indexes for table `vaccination`
--
ALTER TABLE `vaccination`
  ADD PRIMARY KEY (`id`);

--
-- Indexes for table `visit_certificate`
--
ALTER TABLE `visit_certificate`
  ADD PRIMARY KEY (`id`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `body_check`
--
ALTER TABLE `body_check`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `certificates`
--
ALTER TABLE `certificates`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `doctors`
--
ALTER TABLE `doctors`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `faculties`
--
ALTER TABLE `faculties`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `health_visits`
--
ALTER TABLE `health_visits`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `illness`
--
ALTER TABLE `illness`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `medicalcards`
--
ALTER TABLE `medicalcards`
  MODIFY `card_id` int(11) UNSIGNED NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=17;

--
-- AUTO_INCREMENT for table `sick_leave`
--
ALTER TABLE `sick_leave`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;

--
-- AUTO_INCREMENT for table `specialities`
--
ALTER TABLE `specialities`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `students`
--
ALTER TABLE `students`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=31;

--
-- AUTO_INCREMENT for table `vaccination`
--
ALTER TABLE `vaccination`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=2;

--
-- AUTO_INCREMENT for table `visit_certificate`
--
ALTER TABLE `visit_certificate`
  MODIFY `id` int(11) NOT NULL AUTO_INCREMENT;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
