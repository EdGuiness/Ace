use strict;
use warnings;
use YAPE::Regex::Explain;

my $re;
my @match; 
my @nonmatch;

for (<>) {

    chomp;

    unless ($re) {
        $re = $_;
        print "The regular expression /$_/i matches as follows\n";
#        print YAPE::Regex::Explain->new($re)->explain;
        next;
    }

   
    if (/$re/i) {
        if ($1) {
            push @match, $_ . " (captured '$1')";
        } else {
            push @match, $_;
        }
    } else {
        push @nonmatch, $_;
    }
}    
print "\nMATCHES\n", join ("\n",@match) if @match;
print "\n\nDOES NOT MATCH\n", join ("\n",@nonmatch), if @nonmatch;
