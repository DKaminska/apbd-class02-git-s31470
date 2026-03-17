namespace StatisticsHelper {
	//something here in namespace 
	public class StatisticsHelper {
	 public void CalculateMax(int[] values){
	 
	 }
	 //random comment
	 public int CalculateMin(int[] values){
		int result = values[0];
		for(int i=0;i<values.size;i++){
			if(result>values[i]){
				result = values[i];
			}
		}
		return result;
	 }
	}
}