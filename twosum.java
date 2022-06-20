import java.util.*;
public class twosum{
    public static void main(String[] args){
        int[] arr = {2,7,11,15};
        int target = 9;
        Map<Integer, Integer> map = HashMap<>();
        for (int i = 0; i < arr.length; i++){
            map.put(target - arr[i], arr[i]);
        }
        for (Map.Entry() item : map.entrySet()){
            if(item.key + item.value == target){
                System.out.println(item.key +" " + value);
            }
        }
    }
}