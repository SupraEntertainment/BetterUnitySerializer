using System;

public class SerializationManager {

	public void SerializationManager() {
		
	}

	public static void SerializeAsset() {
		//TODO save asset ID
	}

	public static void DeserializeAsset() {
		
	}
}

public interface IBetterUnitySerializable : ISerializable {
	public GUID id;
}
