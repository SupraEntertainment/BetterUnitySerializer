# BetterUnitySerializer

Unitys Serialization is not able to save ScriptableObjects directly inside another scriptableObject AND save them as reference in another spot. 
Essentially... the assetDatabase doesn't generate asset IDs for objects, that aren't scriptableObjects... and if they have asset IDs they cannot be saved inside another asset.

This limitation is rather tiresome, and makes for some ugly workarounds, or simply things that are impossible

## Add to your project or as dependency
`https://github.com/SupraEntertainment/BetterUnitySerializer.git?path=/Packages#main`