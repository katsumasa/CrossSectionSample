# CrossSectionSample
オブジェクト断面図を表示する為のShaderのサンプル

## 概要
空間上に「切断する仮想の平面（Plane）」を定義し、シェーダー内で各ピクセルのワールド座標がその平面のどちら側にあるかを計算（内積/Dot Productを使用）します。手前にある場合はAlpha Clip（Shader Graph）を使用して描画を破棄します。

![CrossSectionTop](https://github.com/user-attachments/assets/329b08eb-c645-41bc-a47e-1cc6b2e3eea7)

## ShaderGraph
<img width="2006" height="914" alt="image" src="https://github.com/user-attachments/assets/a77783cb-8123-4dd3-b804-1ceb2bb6b760" />


