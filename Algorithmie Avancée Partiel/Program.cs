/*
 * Titre: Partiel Algorithmie Avancée
 * Auteur : Yoann Gomis
 * Date : 06/03/2023
 */
using System;
using static System.Char;

namespace Algorithmie_Avancée_Partiel;

internal abstract class Program
{
	public static void Main(string[] args)
	{
		while(true)
		{
			Console.Write("Quel exercice voulez-vous exécuter ? (1 - 10 ou quit) : ");
	        string? ex = Console.ReadLine();
	        string? chaine;
	        int nombre;
	        switch(ex)
	        {
	            case "1":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
            		if(chaine != null) Exercice1(chaine);
            		break;
	            
	            case "2":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
            		if(chaine != null) Exercice2(chaine);
            		break;
	            
	            case "3":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
            		if(chaine != null) Exercice3(chaine);
            		break;
	            
	            case "4":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
            		if(chaine != null) Exercice4(chaine);
            		break;
	            
	            case "5":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
            		if(chaine != null) Exercice5(chaine);
            		break;
	            
	            case "6":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
            		Console.Write("Entrez un nombre : ");
            		nombre = Convert.ToInt32(Console.ReadLine());
            		if(chaine != null) Exercice6(chaine, nombre);
            		break;
	            
	            case "7":
            		Console.Write("Entrez un nombre : ");
            		nombre = Convert.ToInt32(Console.ReadLine());
            		Exercice7(nombre);
            		break;
	            
	            case "8":
            		Console.Write("Entrez un nombre : ");
            		nombre = Convert.ToInt32(Console.ReadLine());
            		Exercice8(nombre);
            		break;
	            
	            case "9":
            		Console.Write("Entrez un nombre : ");
            		nombre = Convert.ToInt32(Console.ReadLine());
            		Exercice9(nombre);
            		break;
	            
	            case "10":
            		Console.Write("Entrez une chaîne de caractères : ");
            		chaine = Console.ReadLine();
                    Console.Write("Entrez une chaîne de caractères : ");
                    string? chaine2 = Console.ReadLine();
                    if(chaine != null && chaine2 != null) Exercice10(chaine, chaine2);
            		break;
	            
	            default:
		            return;
	        }
		}
	}
	
	private static void Exercice1(string chaine)
	{
		//Affiche la liste des caractères de la chaîne dans l'ordre inverse.
		foreach(char lettre in chaine.Reverse())
		{
			Console.Write(lettre);
		}
		Console.WriteLine("");
	}
	
	private static void Exercice2(string chaine)
	{
		//Affiche si la chaine est triée ou non.
		IOrderedEnumerable<char> reverse = chaine.Order();

		for(int i = 0; i < chaine.Length; i++)
		{
			if(chaine[i] == reverse.ElementAt(i)) continue;
			Console.WriteLine("Faux");
			return;
		
		}
		Console.WriteLine("Vrai");
	}
	
	private static void Exercice3(string chaine)
	{
		//Affiche le nombre de mots dans la chaîne.
		List<string> mots = chaine.Split(' ').ToList();
		Console.WriteLine($"Nombre de mots : { mots.Count }");
	}

	private static void Exercice4(string chaine)
	{
		//Affiche le nombre de lettres minuscules et majuscules.
		int min = 0;
		int max = 0;
		foreach (char lettre in chaine)
		{
			//Je fais sauter les espaces considéré comme des majuscules.
			if(lettre == ' ')
			{
				
			}
			else if(lettre == ToUpper(lettre))
			{
				max++;
			}
			else if(lettre == ToLower(lettre))
			{
				min++;
			}
		}
		Console.WriteLine($"Nombre de lettres minuscules : { min }");
		Console.WriteLine($"Nombre de lettres majuscules : { max }");
	}

	private static void Exercice5(string chaine)
	{
		//Affiche une chaine de caractère sans caractère spéciaux.
		foreach(char lettre in chaine)
		{
			int ascii = Convert.ToInt16(lettre);
			//Garde les espaces et les lettres en majuscules et minuscules.
			if(ascii != 32 && (ascii < 65 || (ascii > 90 && ascii < 97) || ascii > 122))
			{
				Console.Write("");
			}
			else
			{
				Console.Write(lettre);
			}
		}
		Console.WriteLine("");
	}

	private static void Exercice6(string chaine, int nombre)
	{
		//Affiche la chaine de caractère avec le nombre de fois indiqué.
		foreach(char lettre in chaine)
		{
			for(int i = 0; i < nombre; i++)
			{
				Console.Write(lettre);
			}
		}
		Console.WriteLine("");
	}

	private static void Exercice7(int nombre)
	{
		//Affiche la somme des nombres impairs jusqu'au nombre indiqué.
		int total = 0;
		string result = $"{ nombre } =>";
		for(int i = 0; i <= nombre; i++)
		{
			if (i % 2 == 0) continue;
			result += $" { i } +";
			total += i;
		}
		result = result.Remove(result.Length-1);
		result += $"= { total }";
		Console.WriteLine(result);
	}

	private static void Exercice8(int nombre)
	{
		//Affiche les nombres pairs jusqu'au nombre indiqué.
		for(int i = 0; i <= nombre; i++)
		{
			if(i % 2 == 0)
			{
				Console.WriteLine($"{ i } est pair");
			}
		}
	}

	private static void Exercice9(int nombre)
	{
		//Affiche vrai si le nombre est un palindrome, faux sinon.
		string chaine = nombre.ToString();
		IEnumerable<char> reverse = chaine.Reverse();
		for(int i = 0; i < chaine.Length; i++)
		{
			if(chaine[i] == reverse.ElementAt(i)) continue;
			Console.WriteLine("Faux");
			return;
		}
		Console.WriteLine("Vrai");
	}

	private static void Exercice10(string chaine, string chaine2)
	{
		string one;
		string two;
		int total = 0;
		if(chaine.Length > chaine2.Length)
		{
			one = chaine;
			two = chaine2;
		}
		else
		{
			one = chaine2;
			two = chaine;
		}

		if(one.Length != two.Length)
		{
			total = one.Length - two.Length;
		}
		for(int i = 0; i < two.Length; i++)
		{
			if(one[i] != two[i])
			{
				total++;
			}
		}
		Console.WriteLine($"Nombre de différences : { total }");
	}
}
