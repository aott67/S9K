import AsyncStorage from "@react-native-async-storage/async-storage";

export const getUserFromStorage = async () => {
    try {
        const jsonValue = await AsyncStorage.getItem("user");
        return jsonValue != null ? JSON.parse(jsonValue) : null;
      } catch (e) {
        console.error("Reading error:", e);
        return null;
      }
}