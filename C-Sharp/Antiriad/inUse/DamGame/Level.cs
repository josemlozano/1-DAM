namespace DamGame
{
    class Level
    {
        byte tileWidth, tileHeight;
        byte levelWidth, levelHeight;
        byte leftMargin, topMargin;
        string[] levelDescription;

        Image trunckL, trunckR, leaf2, 
            floor, roof, leaf, tree,
            tree2, plataformI, plataformB, plataformF,
            eyeL, eyeR, mounthL, mounthR,
            base1, base2, branch, leg, marker;

        public Level()
        {
            tileWidth = 56;
            tileHeight = 56;
            levelWidth = 18;
            levelHeight = 9;
            leftMargin = 5;
            topMargin = 50;

            
            levelDescription = new string[9]
            {
                "_b__________      ",
                "h       #         ",
                "#       #     <p> ",
                "#       #         ",
                "=b      56<pp>    ",
                "h <pp>  34r       ",
                "#       12        ",
                "#       li/       ",
                "------------------",
            };

            floor = new Image("data\\0001.png");
            roof = new Image("data\\techo.png");
            tree = new Image("data\\tronco.png");
            tree2 = new Image("data\\hojas_tronco.png");
            leaf = new Image("data\\hojas.png");
            leaf2 = new Image("data\\borde_hojas2.png");
            plataformI = new Image("data\\platafoma_inicio.png");
            plataformB = new Image("data\\platafoma.png");
            plataformF = new Image("data\\platafoma_fin.png");
            eyeL = new Image("data\\tronco_central_cara2.png");

            eyeR = new Image("data\\tronco_central_cara.png");
            mounthL = new Image("data\\tronco_central_centro2.png");
            mounthR = new Image("data\\tronco_central_centro1.png");
            trunckL = new Image("data\\tronco_central_arriba2.png");
            trunckR = new Image("data\\tronco_central_arriba.png");
            base1 = new Image("data\\tronco_central3.png");
            base2 = new Image("data\\tronco_central1.png");
            leg = new Image("data\\tronco_central2.png");
            branch = new Image("data\\rama.png");
            marker = new Image("data\\marcador.png");
        }

        public void DrawOnHiddenScreen()
        {
            for (int row = 0; row < levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    int xPos = leftMargin + col * tileWidth;
                    int yPos = topMargin + row * tileHeight;
                    switch (levelDescription[row][col])
                    {
                        case '1': Hardware.DrawHiddenImage(trunckL, xPos, yPos); break;
                        case '2': Hardware.DrawHiddenImage(trunckR, xPos, yPos); break;
                        case '3': Hardware.DrawHiddenImage(mounthL, xPos, yPos); break;
                        case '4': Hardware.DrawHiddenImage(mounthR, xPos, yPos); break;
                        case '-': Hardware.DrawHiddenImage(floor, xPos, yPos); break;
                        case '5': Hardware.DrawHiddenImage(eyeL, xPos, yPos); break;
                        case '6': Hardware.DrawHiddenImage(eyeR, xPos, yPos); break;
                        case '<': Hardware.DrawHiddenImage(plataformI, xPos, yPos); break;
                        case '>': Hardware.DrawHiddenImage(plataformF, xPos, yPos); break;
                        case 'b': Hardware.DrawHiddenImage(leaf2, xPos, yPos); break;

                        case '_': Hardware.DrawHiddenImage(roof, xPos, yPos); break;
                        case 'h': Hardware.DrawHiddenImage(leaf, xPos, yPos); break;
                        case '#': Hardware.DrawHiddenImage(tree, xPos, yPos); break;
                        case '=': Hardware.DrawHiddenImage(tree2, xPos, yPos); break;
                        case 'p': Hardware.DrawHiddenImage(plataformB, xPos, yPos); break;
                        case 'l': Hardware.DrawHiddenImage(base1, xPos, yPos); break;
                        case 'i': Hardware.DrawHiddenImage(base2, xPos, yPos); break;
                        case 'r': Hardware.DrawHiddenImage(branch, xPos, yPos); break;
                        case '/': Hardware.DrawHiddenImage(leg, xPos, yPos); break;
                    }
                }
        }

        public bool IsValidMove(int xMin, int yMin, int xMax, int yMax)
        {
            for (int row = 0; row < levelHeight; row++)
                for (int col = 0; col < levelWidth; col++)
                {
                    char tileType = levelDescription[row][col];
                    // If we don't need to check collisions with this tile, we skip it
                    if ((tileType == ' ')  // Empty space
                            || (tileType == 'l') || (tileType == 'i') 
                            || (tileType == '/') || (tileType == '1')
                            || (tileType == '2') || (tileType == '3')
                            || (tileType == '4') || (tileType == 'r')
                            || (tileType == 'b')) 
                        continue;
                    // Otherwise, lets calculate its corners and check rectangular collisions
                    int xPos = leftMargin + col * tileWidth;
                    int yPos = topMargin + row * tileHeight;
                    int xLimit = leftMargin + (col+1) * tileWidth;
                    int yLimit = topMargin + (row+1) * tileHeight;

                    if (Sprite.CheckCollisions(
                            xMin, yMin, xMax, yMax,  // Coords of the sprite
                            xPos, yPos, xLimit, yLimit)) // Coords of current tile
                        return false;
                    }
            // If we have not collided with anything... then we can move
            return true;
        }
    }
}
