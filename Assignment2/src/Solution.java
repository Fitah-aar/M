import java.util.Stack;

class Solution {
    public String removeDuplicates(String s) {
        // Create a Stack to store characters
        Stack<Character> stack = new Stack<>();

        for (int i = 0; i < s.length(); i++) {
            char current = s.charAt(i);

            if (!stack.isEmpty() && stack.peek() == current) {
                stack.pop();
            } else {
                stack.push(current);
            }
        }

        // Build and return the final String using StringBuilder
        StringBuilder sb = new StringBuilder();
        for (char c : stack) {
            sb.append(c);
        }

        return sb.toString();
    }

    // Main method to make the file runnable and test the code
    public static void main(String[] args) {
        Solution sol = new Solution();

        // Test
        String testStr = "abbaca";
        String result = sol.removeDuplicates(testStr);

        // Print the results to the console
        System.out.println("Input: " + testStr);
        System.out.println("Output: " + result);
    }
}