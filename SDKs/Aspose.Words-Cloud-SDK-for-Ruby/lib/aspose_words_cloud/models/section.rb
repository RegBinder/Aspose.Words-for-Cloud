module AsposeWordsCloud
  # 
  class Section < BaseObject
    attr_accessor :paragraphs, :page_setup, :link
    # attribute mapping from ruby-style variable name to JSON key
    def self.attribute_map
      {
        
        # 
        :'paragraphs' => :'Paragraphs',
        
        # 
        :'page_setup' => :'PageSetup',
        
        # 
        :'link' => :'link'
        
      }
    end

    # attribute type
    def self.swagger_types
      {
        :'paragraphs' => :'LinkElement',
        :'page_setup' => :'LinkElement',
        :'link' => :'Link'
        
      }
    end

    def initialize(attributes = {})
      return if !attributes.is_a?(Hash) || attributes.empty?

      # convert string to symbol for hash key
      attributes = attributes.inject({}){|memo,(k,v)| memo[k.to_sym] = v; memo}

      
      if attributes[:'Paragraphs']
        self.paragraphs = attributes[:'Paragraphs']
      end
      
      if attributes[:'PageSetup']
        self.page_setup = attributes[:'PageSetup']
      end
      
      if attributes[:'link']
        self.link = attributes[:'link']
      end
      
    end

  end
end
