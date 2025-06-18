public class Test {
    public static void main(String[] args) {
       
        Logger logger1 = Logger.getInstance();
        Logger logger2 = Logger.getInstance();

        logger1.log("Logger 1 is logging.");
        logger2.log("Logger 2 is logging.");
        
        if (logger1 == logger2) {
            System.out.println("Only one instance of Logger exists.");
        } else {
            System.out.println("Multiple instances of Logger exist.");
        }
    }
}
