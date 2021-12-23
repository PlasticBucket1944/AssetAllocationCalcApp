# 概要
投資信託の合計評価額や比率を計算するアプリ
SBIと楽天２つ使ってるので手動で計算するのが面倒だった
２つのサイトから資産状況をCSV出力してそれを読み込んで計算する

# フォルダ構成
AssetAllocationCalcApp.exe

AssetAllocationCalcApp.exe.config

FundGroupMaster.csv

この３つのファイルを同ディレクトリ内に配置してください。※FundGroupMaster.csvは無くても動きます。

# 使い方
１．証券サイトから資産状況をCSV出力する
SBI ：口座管理→トータルリターン→保有中→CSVダウンロード
楽天：投資信託→保有商品一覧→CSVで保存

２．出力したCSVファイルをアプリケーションに読み込む

３．種別ごとに集計されるので調整する

## FundGroupMasterについて
ファンド名と種別を紐づけるマスター
以下のように作成する

NAME,TYPE

ファンドA,国内株式

ファンドB,国内株式

ファンドC,先進国債券

CSVを取り込んだ際に検索をかけ種別列の初期値にする

# ビルド方法
cloneしてビルドすればEXEできるのでそれを叩く

# その他めも
まさか同じファンドでも証券ごとに名称が違うとは思わなかった・・・
株と違って一意キーが無いから集計しづらいわ。
