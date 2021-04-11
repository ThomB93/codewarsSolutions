//Complete the solution so that it reverses all of the words within the string passed in.
object Kata {
  def reverseWords(str: String): String = (str.reverse.split(" ", -1) map(_.reverse)).mkString(" ")
}