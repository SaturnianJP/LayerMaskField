試しに作ってみたものなのでバグがあるかもしれないです。

以下のように使用してください。
LightコンポーネントのCullingMaskを変更する例です。

labelはnullにすると内部処理でスルー出来るみたいです。
```
light.cullingMask = ReflectionMethods.LayerMaskField(rect, light.cullingMask, null);
```
