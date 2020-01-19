/**
 * This class models a Dog.
 * @author Copied from Dr. K
 * @version 1.0
 * Proj1-Dog
 * Sp2020
 */
namespace TestDog{
    public class Dog{

        private int age;
        private string name;

        /**
        * Empty-argument constructor to put object
        * into a consistent state.
        */
        public Dog()
        {
            age = 0;
            name = "";
        }//end constructor

        /**
         * Constructor accepts the age and
	     * name of the dog. This is the preferred
	     * constructor.
	     * @param age
	     * @param name
         */
         public Dog(int age, string name)
        {
            this.setAge(age);
            this.setName(name);
        }//end constructor
        public int calcDogYears()
        {
            int dogYears = 15 + (this.age - 1) * 7;
            return dogYears;
        }
        /**
	     * Getter for age
	     * @return
	     */
        public int getAge()
        {
            return age;
        }//end getAge

        /**
          * Setter for age
          * Checks the bounds so 
          * @param age
          */
        public void setAge(int age)
        {
            if (age < 0)
                this.age = 0;
            else
                this.age = age;
        }//end setAge
         /**
          * Getter for name
          * @return
          */
        public string getName()
        {
            return name;
        }//end getName
         /**
          * Setter for name. Ensures that only
          * alpha characters are allowed in the name.
          * @param name
          */
        public void setName(string name)
        {
            bool valid = true;
            char[] n = name.ToCharArray();

            foreach (char c in n)
            {
                if (!char.IsLetter(c))
                {
                    valid = false;
                    break;
                }
            }

            if (valid)
                this.name = name;
            else
                this.name = "";

        }//end setName

    public string toString()
        {
            return "Dog [age=" + age + ", name=" + name + "]";
        }//end toString
    }//end class
}//end namespace