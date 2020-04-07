-- MySQL dump 10.13  Distrib 8.0.19, for macos10.15 (x86_64)
--
-- Host: localhost    Database: lienquanmobile
-- ------------------------------------------------------
-- Server version	5.7.29

/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!50503 SET NAMES utf8 */;
/*!40103 SET @OLD_TIME_ZONE=@@TIME_ZONE */;
/*!40103 SET TIME_ZONE='+00:00' */;
/*!40014 SET @OLD_UNIQUE_CHECKS=@@UNIQUE_CHECKS, UNIQUE_CHECKS=0 */;
/*!40014 SET @OLD_FOREIGN_KEY_CHECKS=@@FOREIGN_KEY_CHECKS, FOREIGN_KEY_CHECKS=0 */;
/*!40101 SET @OLD_SQL_MODE=@@SQL_MODE, SQL_MODE='NO_AUTO_VALUE_ON_ZERO' */;
/*!40111 SET @OLD_SQL_NOTES=@@SQL_NOTES, SQL_NOTES=0 */;

--
-- Table structure for table `skill`
--

DROP TABLE IF EXISTS `skill`;
/*!40101 SET @saved_cs_client     = @@character_set_client */;
/*!50503 SET character_set_client = utf8mb4 */;
CREATE TABLE `skill` (
  `skillId` int(11) NOT NULL,
  `heroId` int(11) NOT NULL,
  `image` text COLLATE utf8_unicode_ci,
  `name` varchar(5000) CHARACTER SET utf8 DEFAULT NULL,
  `content` varchar(5000) CHARACTER SET utf8 DEFAULT NULL,
  PRIMARY KEY (`skillId`,`heroId`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_unicode_ci;
/*!40101 SET character_set_client = @saved_cs_client */;

--
-- Dumping data for table `skill`
--

LOCK TABLES `skill` WRITE;
/*!40000 ALTER TABLE `skill` DISABLE KEYS */;
INSERT INTO `skill` VALUES (0,1,'https://lienquan.garena.vn/files/skill/icon/b3fccac3d3894113f82174d3ec963500583e9cb3ac80c.png','ÁM KHÍ','Hồi chiêu: 0 giây\nTiêu hao: 0 năng lượng\nNội tại: Mỗi đòn đánh thường thứ ba bắn một đoản kiếm ngẫu nhiên kèm hiệu ứng đặc biệt. Valhein nhận một điểm cộng dồn \"Thợ săn\" giúp tăng 10% tốc chạy trong 2 giây, cộng dồn tối đa 5 lần.\n\nMàu đỏ (40%): 75 (+9 cấp tướng) (+1.15 công vật lý) (+0.65 công phép) sát thương phép, sát thương diện rộng.\n\nMàu xanh (20%): 75 (+9 cấp tướng) (+0.75 công vật lý) (+0.55 công phép) sát thương phép, giảm thời gian hồi chiêu của tất cả chiêu 1 giây và hồi máu cùng năng lượng (0.15 công vật lý) + (0.08 công phép).\n\nMàu vàng (40%): 75 (+9 cấp tướng) (+0.75 công vật lý) (+0.55 công phép) sát thương phép, choáng 0.75 giây.'),(0,2,'https://lienquan.garena.vn/files/skill/icon/19c9c4d9e177ee23ea0d5a9cefafb96a583e9dfef0882.png','QUYỀN NĂNG MA THUẬT','Hồi chiêu: 75 giây\nTiêu hao: 0 năng lượng\nNội tại: Khi máu của Thane dưới 30%, hắn có thể hồi lại 24% máu tối đa của mình và nhận 25% miễn thương trong 4 giây'),(1,1,'https://lienquan.garena.vn/files/skill/icon/1ec3d200fd56cb45b716d1d5ee94a746583e9d4397bca.png','LỜI NGUYỀN TỬ VONG','Hồi chiêu: 10/9.4/8.8/8.2/7.6/7 giây\nTiêu hao: 70/80/90/100/110/120 năng lượng\nValhein ném một phi tiêu hoàng kim vào mục tiêu, gây 150/170/190/210/230/250 (+0.58 Công vật lý)(+0.6 Công phép) sát thương phép, và làm choáng mục tiêu, đồng thời giúp tăng một điểm hiệu ứng \"Thợ săn\".'),(1,2,'https://lienquan.garena.vn/files/skill/icon/d16cdf12dab4f627fe439a5e8252c4f4583e9e261cfaf.png','XUNG PHONG','Hồi chiêu: 12/11.2/10.4/9.6/8.8/8 giây\nTiêu hao: 60/65/70/75/80/85 năng lượng\nThane lao đến gây 60/75/90/105/120/135 (+0.35 công vật lí) sát thương vật lý theo từng đợt (càng gần càng nhiều sát thương) lên kẻ địch kèm hiệu ứng đẩy lùi liên tục. Khi chiêu kết thúc sẽ hất văng nạn nhân.'),(2,1,'https://lienquan.garena.vn/files/skill/icon/c40655d6952c05bcb1e43aec3037328e583e9d0761f74.png','CHUYẾN SĂN MẠO HIỂM','Hồi chiêu: 9/8.6/8.2/7.8/7.4/7 giây\nTiêu hao: 65/70/75/80/85/90 năng lượng\nValhein ném một phi tiêu đặc biệt vào kẻ thù trong phạm vi, gây 300/330/360/390/420/450 (+0.8 Công vật lý) (+0.8 Công phép) sát thương phép, đồng thời giúp tăng một điểm hiệu ứng \"Thợ săn\".'),(2,2,'https://lienquan.garena.vn/files/skill/icon/b0e3537a79816da5c312de91ee82217c583e9e469712e.png','GƯƠM THẦN','Hồi chiêu: 8.5/8/7.5/7/6.5/6 giây\nTiêu hao: 75/80/85/90/95/100 năng lượng\nThane phóng lên trời cắm kiếm thần xuống đất, gây 200/260/320/380/440/500+(0.58 công vật lí) sát thương vật lý lên kẻ thù trong phạm vi, hất văng và làm chậm [90%] tốc chạy của các nạn nhân trong 2.5 giây.'),(3,1,'https://lienquan.garena.vn/files/skill/icon/0fd55b686edc386f5f1937a09de2d1f1583e9d6a7fcc5.png','BÃO ĐẠN','Hồi chiêu: 24/20/16 giây\nTiêu hao: 100/125/150 năng lượng\nValhein bắn sáu viên đạn bạc gây 200/250/300 (+1.0 Công vật lý)(+1.0 Công phép) sát thương phép lên kẻ địch. Mỗi phát đạn trúng đích giúp tăng 10% tốc chạy (tối đa 60%), và 8% tốc đánh (tối đa 48%), kéo dài 3 giây. Nếu như kẻ địch trúng nhiều hơn một viên đạn, kẻ đó chỉ phải chịu 40% sát thương từ viên thứ hai'),(3,2,'https://lienquan.garena.vn/files/skill/icon/4ea990168ba972f3dc2b74f4eb9a2ccf583e9e6523ec9.png','EXCALIBUR','Hồi chiêu: 40/35/30 giây\nTiêu hao: 150/165/180 năng lượng\nThane rút kiếm thần chém về phía trước, gây 500/750/1000(+0.9 Công vật lý) sát thương chuẩn, kèm 15% máu đã mất của mục tiêu thành sát thương vật lý. Thane nhận 20% miễn thương và không thể bị ngăn cản khi đang tung chiêu.');
/*!40000 ALTER TABLE `skill` ENABLE KEYS */;
UNLOCK TABLES;
/*!40103 SET TIME_ZONE=@OLD_TIME_ZONE */;

/*!40101 SET SQL_MODE=@OLD_SQL_MODE */;
/*!40014 SET FOREIGN_KEY_CHECKS=@OLD_FOREIGN_KEY_CHECKS */;
/*!40014 SET UNIQUE_CHECKS=@OLD_UNIQUE_CHECKS */;
/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
/*!40111 SET SQL_NOTES=@OLD_SQL_NOTES */;

-- Dump completed on 2020-04-07 10:27:38
