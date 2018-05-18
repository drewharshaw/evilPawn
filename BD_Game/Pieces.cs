﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BD_Game {

    public class Position {

        public uint xCoord;
        public uint yCoord;

        //constructor
        public Position(uint a, uint b) {

            this.xCoord = a;
            this.yCoord = b;

        }

    }



    public class Piece {

        private uint positionX {get; set;}
        private uint positionY {get; set;}
        private string colour {get; set;}

        public List<object> legalMoves = new List<object>();
    }

    public class Pawn : Piece{

        //default constructor
        public Pawn (string colour, uint xCoord, uint yCoord, ref Piece[][] boardPosition) {

            //set colour
            this.colour = (colour);

            //set current position
            positionX = xCoord;
            Pawn.positionY = yCoord;
            
        }


        public void CalculateLegalMoves(ref Piece[][] boardPosition) {

            //check left attacking square legal
            if (Pawn.positionX > 0 && boardPosition[positionX - 1][positionY + 1] != null) {
                //if enemy
                if(!(boardPosition[positionX - 1][positionY + 1].getColour().Equals(this.getColour()))) {
                    //add to legal moves
                    legalMoves.Add(new Position(positionX - 1, positionY + 1));
                }
            }
            //check right attaching square
            if (positionX < 7 && boardPosition[positionX + 1][positionY + 1] != null) {
                //if enemy
                if (!(boardPosition[positionX + 1][positionY + 1].getColour().Equals(this.getColour()))) {
                    //add to legal moves
                    legalMoves.Add(new Position(positionX + 1, positionY + 1));
                }
            }

            //1 move rule
            if(boardPosition[positionX][positionY + 1] == null) {
                //add to legal moves
                legalMoves.Add(new Position(positionX, positionY + 1));

                // 2 move rule
            } else if (positionY == 1 && boardPosition[positionX][positionY + 2] == null) {
                //add to legal moves
                legalMoves.Add(new Position(positionX, positionY + 2));
            }
        }
    }

    class Rook : Piece {
        public int LegalMoves() {


            return 0;
        }
    }
    


    class Knight : Piece {

    }

    class Bishop : Piece {

    }



    class King : Piece {
        public int LegalMoves(ref string[][] BoardPosition) {



            return 0;

        }
    }

    class Queen : Piece {

    }

}
