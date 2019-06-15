1.	/*
2.	 * To change this template, choose Tools | Templates
3.	 * and open the template in the editor.
4.	 */
5.	package javaapplication219;
6.	 
7.	import java.io.BufferedReader;
8.	import java.io.IOException;
9.	import java.io.InputStreamReader;
10.	import java.math.BigInteger;
11.	 
12.	/**
13.	 *
14.	 * @author Administrador
15.	 */
16.	public class JavaApplication219 {
17.	 
18.	    /**
19.	     * @param args the command line arguments
20.	     */
21.	    public static void main(String[] args) throws IOException {
22.	        // TODO code application logic here
23.	       
24.	         // String s = "99999999991999999";
25.	       
26.	          BufferedReader br = new BufferedReader(new InputStreamReader(System.in));
27.	         
28.	          while(true) {
29.	             
30.	              String[] input = br.readLine().split(" ");
31.	              String dig = input[0];
32.	              String num = input[1];
33.	             
34.	              if(dig.equals("0") && num.equals("0")) {
35.	                  break;
36.	              }
37.	             
38.	             
39.	              String concat ="";
40.	              for(int i =0; i<num.length(); i++) {
41.	                  if(num.charAt(i) != dig.charAt(0)) {
42.	                      concat += num.charAt(i);
43.	                  }
44.	              }
45.	             
46.	              if(concat.length() == 0) {
47.	                  System.out.println(0);
48.	                         
49.	              }
50.	              else{
51.	                BigInteger big = new BigInteger(concat);
52.	                System.out.println(big);
53.	              }
54.	          }
55.	 
56.	    }
57.	}
