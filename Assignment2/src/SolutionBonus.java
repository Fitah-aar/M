import java.util.Stack;

class SolutionBonus {
    public String removeDuplicates(String s) {
        // Create two stacks one for characters and one for their counts
        Stack<Character> charStack = new Stack<>();
        Stack<Integer> countStack = new Stack<>();

        for (int i = 0; i < s.length(); i++) {
            char current = s.charAt(i);

            if (!charStack.isEmpty() && charStack.peek() == current) {
                int count = countStack.pop() + 1;
                if (count == 3) {
                    charStack.pop();
                } else {
                    countStack.push(count);
                }
            } else {

                charStack.push(current);
                countStack.push(1);
            }
        }

        // Rebuild the final String from the stacks
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < charStack.size(); i++) {
            char c = charStack.get(i);
            int count = countStack.get(i);
            for (int j = 0; j < count; j++) {
                sb.append(c);
            }
        }

        return sb.toString();
    }

    // Main method to make the file runnable and test the bonus code
    public static void main(String[] args) {
        SolutionBonus sol = new SolutionBonus();

        // Test case for bonus challenge
        String testStr = "deeedbbcccbdaa";
        String result = sol.removeDuplicates(testStr);

        // Print the results to the console
        System.out.println("Input: " + testStr);
        System.out.println("Output: " + result);
    }
}