package AsposeWordsCloud::Object::Color;

require 5.6.0;
use strict;
use warnings;
use utf8;
use JSON qw(decode_json);
use Data::Dumper;
use Module::Runtime qw(use_module);
use Log::Any qw($log);
use Date::Parse;
use DateTime;

use base "AsposeWordsCloud::Object::BaseObject";

#
#
#
#NOTE: This class is auto generated by the swagger code generator program. Do not edit the class manually.
#

my $swagger_types = {
    'R' => 'string',
    'G' => 'string',
    'B' => 'string',
    'A' => 'string',
    'IsKnownColor' => 'boolean',
    'IsEmpty' => 'boolean',
    'IsNamedColor' => 'boolean',
    'IsSystemColor' => 'boolean',
    'Name' => 'string'
};

my $attribute_map = {
    'R' => 'R',
    'G' => 'G',
    'B' => 'B',
    'A' => 'A',
    'IsKnownColor' => 'IsKnownColor',
    'IsEmpty' => 'IsEmpty',
    'IsNamedColor' => 'IsNamedColor',
    'IsSystemColor' => 'IsSystemColor',
    'Name' => 'Name'
};

# new object
sub new { 
    my ($class, %args) = @_; 
    my $self = { 
        #
        'R' => $args{'R'}, 
        #
        'G' => $args{'G'}, 
        #
        'B' => $args{'B'}, 
        #
        'A' => $args{'A'}, 
        #
        'IsKnownColor' => $args{'IsKnownColor'}, 
        #
        'IsEmpty' => $args{'IsEmpty'}, 
        #
        'IsNamedColor' => $args{'IsNamedColor'}, 
        #
        'IsSystemColor' => $args{'IsSystemColor'}, 
        #
        'Name' => $args{'Name'}
    }; 

    return bless $self, $class; 
}  

# get swagger type of the attribute
sub get_swagger_types {
    return $swagger_types;
}

# get attribute mappping
sub get_attribute_map {
    return $attribute_map;
}

1;
