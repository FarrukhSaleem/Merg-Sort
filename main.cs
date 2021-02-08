using System;

class MainClass {  
  public static void Main (string[] args) {
    int[] arr = new int[] {20,6,88,1,0,2,66,2,7,66};
    Console.WriteLine("Given Array:");
    foreach(var item in arr){
     Console.Write(item+" ,");
    }
    Sort(arr);
    Console.WriteLine("\nArray after sort:");
    foreach(var item in arr){
     Console.Write(item+" ,");
    }
  }  
  public static void Sort(int[] arr){   
    if(arr.Length<2)
      return;
    int mid = arr.Length/2;
    int[] leftarr = new int[mid];
    int[] rightarr= new int[arr.Length-mid];
    for(int i=0;i<mid;i++){
      leftarr[i]=arr[i];
    }
    Console.WriteLine("\nLeft Array:");
    foreach(var item in leftarr){
     Console.Write(item+" ,");
    }
    for(int j=mid;j<arr.Length;j++){
      rightarr[j-mid]=arr[j];
    }
    Console.WriteLine("\nRight Array:");
    foreach(var item in rightarr){
     Console.Write(item+" ,");
    }
    Sort(leftarr);
    Sort(rightarr);
    Merge(leftarr,rightarr,arr);    
  }
  public static void Merge(int[] left,int[] right,int[] arr){
    int l=0,r=0,a=0;
    while (l<left.Length && r<right.Length){
      if (left[l]<right[r]){
        arr[a++]=left[l++];
      }
      else{
        arr[a++]=right[r++];
      }
    }
    while(l<left.Length){
      arr[a++]=left[l++];
    }
    while(r<right.Length){
      arr[a++]=right[r++];
    }
  }
}