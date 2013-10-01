#!/usr/local/bin/perl
use strict;
use warnings;
use Cwd;





my @nonStrings = ("AtomicNumber");
	
	
	
	
	
	
	
	
my $file = "Database.xml";
my $document = do {
    local $/ = undef;
    open my $fh, "<", $file;
    <$fh>;
};
$document =~ s/\t|\n//g;

my $declaration = "";
my $listing = "\n\n" . "<SPACE>" . "public static readonly List<Element> elementList = new List<Element>()\n" . "<SPACE>" . "{";
my $dictionary = "\n\n" . "<SPACE>" . "public static readonly Dictionary<string, Element> elementDictionary = new Dictionary<string, Element>()\n" . "<SPACE>" . "{";

while($document =~ s/<Element>(.*?)<\/Element>//s)
{
	my %element;
	my $attrs = $1;
	while($attrs =~ s/<(\S+?)>(.*?)<\/\1>//s)
	{
		$element{$1} = $2;
	}
	
	$declaration .= "\n" . "<SPACE>" . "public static readonly " . $element{"Classification"} . " " . $element{"Name"} . " = new " . $element{"Classification"} . "(";
	$listing .= "\n" . "<SPACE>" . "\t" . $element{"Name"} . ",";
	$dictionary .= "\n" . "<SPACE>" . "\t" . "{\"" . ($element{"Name"}) . "\", " . $element{"Name"} . "}," . "\n" . "<SPACE>" . "\t" . "{\"" . ($element{"Symbol"}) . "\", " . $element{"Name"} . "}," . "\n" . "<SPACE>" . "\t" . "{\"" . $element{"AtomicNumber"} . "\", " . $element{"Name"} . "},";
	
	foreach my $attrName (keys %element)
	{
		my $attrVal = $element{$attrName};
		if ( grep( /^$attrName$/, @nonStrings ) ) 
		{
			$declaration .= $attrName . ": " . $attrVal . ", ";
		}
		else
		{
			$declaration .= $attrName . ": \"" . $attrVal . "\", ";
		}
	}
	$declaration =~ s/,\s$/);/;
}

$listing .= "\n\t\t};";
$dictionary .= "\n\t\t};";

my $output = $declaration . $listing . $dictionary . "\n" . "<SPACE>";

$file = cwd() .'/Atomizer/ElementDatabase.cs';

$document = do {
    local $/ = undef;
    open my $fh, "<", $file;
    <$fh>;
};

if($document =~ /(?:\n|\r)(\s*)#region Perl Generated Code.*?#endregion/s)
{
	my $spacing = $1;
	$spacing =~ s/(\r|\n)//g;
	#print "<" . $spacing . ">";
	$output =~ s/<SPACE>/$spacing/g;
	
	$document =~ s/#region Perl Generated Code.*?#endregion/#region Perl Generated Code$output#endregion/s;

	open (MYFILE, ">", $file);
	print MYFILE $document;
	close (MYFILE); 
}