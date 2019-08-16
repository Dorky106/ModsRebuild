using Pipliz.JSON;
using System;

namespace PhentrixGames.NewColonyAPI.Textures
{
    public class BaseTexture
    {
        public string Name { get; private set; }

        public string Albedo { get; private set; }

        public string Emissive { get; private set; }

        public string Height { get; private set; }

        public string Normal { get; private set; }

        public bool Replace { get; private set; }

        public BaseTexture(string id, string albedo, string emissive = null, string height = null, string normal = null)
        {
            if (id != null && id != "")
            {
                if (albedo != null && albedo != "")
                {
                    Name = id;
                    Albedo = albedo;
                    Emissive = emissive;
                    Height = height;
                    Normal = normal;
                    Replace = false;
                }
                else
                {
                    throw new Exception("Albedo can not be set to null or \"\"");
                }
            }
            else
            {
                throw new Exception("Texture needs to have an ID in order to be registered!");
            }
        }

        public void Register()
        {
            JSONNode texture = new JSONNode();
            texture.SetAs("albedo", Albedo);

            if (Emissive != null && Emissive != "")
                texture.SetAs("emissive", Emissive);

            if (Height != null && Height != "")
                texture.SetAs("height", Height);

            if (Normal != null && Normal != "")
                texture.SetAs("normal", Normal);

            ItemTypesServer.SetTextureMapping(Name, new ItemTypesServer.TextureMapping(texture));
        }
    }
}