#                   项目一技术文档

## 1. 整体框架

本项目提供商城界面并显示商品信息，分为每日精选和士兵招募，动态的刷新商品信息，支持购买商品。



## 2.目录结构





## 3.代码逻辑分层

| 层     | 文件夹                                | 主要职责             | 调用关系 |
| ------ | ------------------------------------- | -------------------- | -------- |
| 脚本层 | Assets/Function1                      | 点击按钮进行页面跳转 |          |
| 脚本层 | Assets/Function2                      | 控制每日精选         |          |
| 脚本层 | Assets/Function3                      | 控制士兵招募         |          |
| 视图层 | Assets/Scenes/Test/GUI/ParentPanel | 显示按键             |          |
| 视图层 | Assets/Scenes/Test/GUI/MallPanel   | 显示商城UI           |          |
| 工具层 | Assets/prefab                         | 存放UI的预制件       |          |
| 工具层 | Assets/ThirdParty                     | 第三方插件           |          |
| 数据层 | Assets/JSON                           | 存放JSON数据


## 4.存储设计

JSON存储

| 内容           | field       | 类型    |
| -------------- | ----------- | ------- |
| 商品id         | productId   | int类型 |
| 商品类型       | type        | int类型 |
| 商品子类型     | subType     | int类型 |
| 商品数量       | num         | int类型 |
| 需花费金币     | costGem     | int类型 |
| 商品是否已购买 | isPurchased | int类型 |



## 5.流程图

<img width="558" alt="截屏2021-11-12 上午11 17 23" src="https://user-images.githubusercontent.com/93905958/141410460-e5ebc020-49c4-4992-b4a4-2ede333536b8.png">


## 6.第三方库

使用https://github.com/Bunny83/SimpleJSON来解析JSON文件

## 7.如何编译执行

