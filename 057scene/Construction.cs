// Author: Josef Pelikan

using System.IO;
using OpenTK;
using MathSupport;
using System;

namespace Scene3D
{
  public class Construction
  {
    #region Form initialization

    /// <summary>
    /// Optional data initialization.
    /// </summary>
    public static void InitParams ( out string param )
    {
      param = "";
    }

    #endregion

    #region Instance data

    // !!! If you need any instance data, put them here..

    #endregion

    #region Construction

    public Construction ()
    {
      // !!! Any one-time initialization code goes here..
    }

    #endregion

    #region Mesh construction

    /// <summary>
    /// Construct a new Brep solid (preferebaly closed = regular one).
    /// </summary>
    /// <param name="scene">B-rep scene to be modified</param>
    /// <param name="m">Transform matrix (object-space to world-space)</param>
    /// <param name="param">Shape parameters if needed</param>
    /// <returns>Number of generated faces (0 in case of failure)</returns>
    public int AddMesh ( SceneBrep scene, Matrix4 m, string param )
    {
      // !!!{{ TODO: put your Mesh-construction code here
        GenerateSierpinskiCube(scene, m, Vector3.Zero, 1.0f, Vector3.Zero, 3);
        //createCube(scene, m, Vector3.Zero, 1.0f, Vector3.Zero);

        //int[] v = new int[4];

        //Vector3 A = new Vector3(0.0f, 0.0f, 0.0f);
        //Vector3 B = new Vector3(1.0f, 0.0f, 0.0f);
        //Vector3 C = new Vector3(0.0f, 1.0f, 0.0f);
        //Vector3 D = new Vector3(1.1f, 1.1f, 0.0f);

        //v[0] = scene.AddVertex(Vector3.TransformPosition(A, m));
        //v[1] = scene.AddVertex(Vector3.TransformPosition(B, m));
        //v[2] = scene.AddVertex(Vector3.TransformPosition(C, m));
        //v[3] = scene.AddVertex(Vector3.TransformPosition(D, m));

        //scene.SetNormal(v[0], Vector3.TransformVector(A, m).Normalized());
        //scene.SetNormal(v[1], Vector3.TransformVector(B, m).Normalized());
        //scene.SetNormal(v[2], Vector3.TransformVector(C, m).Normalized());
        //scene.SetNormal(v[3], Vector3.TransformVector(D, m).Normalized());

        //scene.AddTriangle(v[0], v[1], v[3]);
        //scene.AddTriangle(v[0], v[3], v[2]);

      return 6;

      // !!!}}
    }

    private void GenerateSierpinskiCube(SceneBrep scene, Matrix4 m, Vector3 center, float size, Vector3 shift, int it)
    {
        if (it > 0)
        {
            Vector3 sh = new Vector3(-size, 0.0f, 0.0f) + shift;
            createCube(scene, m, center, size, sh);

            sh = new Vector3(size, 0.0f, 0.0f) + shift;
            createCube(scene, m, center, size, sh);

            sh = new Vector3(0.0f, -size, 0.0f) + shift;
            createCube(scene, m, center, size, sh);

            sh = new Vector3(0.0f, size, 0.0f) + shift;
            createCube(scene, m, center, size, sh);

            sh = new Vector3(0.0f, 0.0f, -size) + shift;
            createCube(scene, m, center, size, sh);

            sh = new Vector3(0.0f, 0.0f, size) + shift;
            createCube(scene, m, center, size, sh);

            sh = new Vector3(size + size / 3, size + size / 3, size + size / 3);
            GenerateSierpinskiCube(scene, m, new Vector3(size, size, size), size / 3, sh+center, it - 1);

            //sh = new Vector3(size + size / 3, size + size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, Vector3.Zero, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, size + size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, Vector3.Zero, size / 3, sh, it - 1);

            //sh = new Vector3(size / 3, -size + size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, Vector3.Zero, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, size + size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, Vector3.Zero, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, -size + size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, size + size / 3, size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, size + size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, -size + size / 3, size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, -size + size / 3, size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, -size + size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, size + size / 3, size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size + size / 3, size + size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, -size + size / 3, size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, -size + size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(size / 3, -size + size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            //sh = new Vector3(-size + size / 3, size / 3, -size + size / 3);
            //GenerateSierpinskiCube(scene, m, center, size / 3, sh, it - 1);

            it--;
        }
    }

    private void createCube(SceneBrep scene, Matrix4 m, Vector3 center, float size, Vector3 shift)
    {
        int[] v = new int[8];
        Vector3 A = new Vector3(0.0f, 0.0f, 0.0f);
        Vector3 B = new Vector3(size, 0.0f, 0.0f);
        Vector3 C = new Vector3(0.0f, size, 0.0f);
        Vector3 D = new Vector3(size, size, 0.0f);
        Vector3 E = new Vector3(0.0f, 0.0f, size);
        Vector3 F = new Vector3(size, 0.0f, size);
        Vector3 G = new Vector3(0.0f, size, size);
        Vector3 H = new Vector3(size, size, size);
        A += shift;
        B += shift;
        C += shift;
        D += shift;
        E += shift;
        F += shift;
        G += shift;
        H += shift;

        v[0] = scene.AddVertex(Vector3.TransformPosition(A, m));
        v[1] = scene.AddVertex(Vector3.TransformPosition(B, m));
        v[2] = scene.AddVertex(Vector3.TransformPosition(C, m));
        v[3] = scene.AddVertex(Vector3.TransformPosition(D, m));
        v[4] = scene.AddVertex(Vector3.TransformPosition(E, m));
        v[5] = scene.AddVertex(Vector3.TransformPosition(F, m));
        v[6] = scene.AddVertex(Vector3.TransformPosition(G, m));
        v[7] = scene.AddVertex(Vector3.TransformPosition(H, m));

        scene.SetNormal(v[0], Vector3.TransformVector(A, m).Normalized());
        scene.SetNormal(v[1], Vector3.TransformVector(B, m).Normalized());
        scene.SetNormal(v[2], Vector3.TransformVector(C, m).Normalized());
        scene.SetNormal(v[3], Vector3.TransformVector(D, m).Normalized());
        scene.SetNormal(v[4], Vector3.TransformVector(E, m).Normalized());
        scene.SetNormal(v[5], Vector3.TransformVector(F, m).Normalized());
        scene.SetNormal(v[6], Vector3.TransformVector(G, m).Normalized());
        scene.SetNormal(v[7], Vector3.TransformVector(H, m).Normalized());

        CreateSquare(scene, v[0], v[1], v[2], v[3]);
        CreateSquare(scene, v[4], v[5], v[0], v[1]);
        CreateSquare(scene, v[0], v[2], v[4], v[6]);
        CreateSquare(scene, v[2], v[3], v[6], v[7]);
        CreateSquare(scene, v[3], v[1], v[7], v[5]);
        CreateSquare(scene, v[6], v[7], v[4], v[5]);
    }

    private void CreateSquare(SceneBrep scene, int fV, int sV, int tV, int foV)
    {
        scene.AddTriangle(fV, sV, foV);
        scene.AddTriangle(fV, foV, tV);
    }

    private int CreateTetrahedron ( SceneBrep scene, Matrix4 m, Vector3 center, float size)
    {
      int[] v = new int[ 4 ];
      float z = (float)(size * Math.Sqrt( 0.5 ));

      Vector3 A = new Vector3(  size,  0.0f, -z );
      Vector3 B = new Vector3( -size,  0.0f, -z );
      Vector3 C = new Vector3(  0.0f,  size,  z );
      Vector3 D = new Vector3(  0.0f, -size,  z );

      // vertices:
      v[ 0 ] = scene.AddVertex( Vector3.TransformPosition( A, m ) );
      v[ 1 ] = scene.AddVertex( Vector3.TransformPosition( B, m ) );
      v[ 2 ] = scene.AddVertex( Vector3.TransformPosition( C, m ) );
      v[ 3 ] = scene.AddVertex( Vector3.TransformPosition( D, m ) );

      // normal vectors:
      scene.SetNormal( v[ 0 ], Vector3.TransformVector( A, m ).Normalized() );
      scene.SetNormal( v[ 1 ], Vector3.TransformVector( B, m ).Normalized() );
      scene.SetNormal( v[ 2 ], Vector3.TransformVector( C, m ).Normalized() );
      scene.SetNormal( v[ 3 ], Vector3.TransformVector( D, m ).Normalized() );

      // triangle faces:
      scene.AddTriangle( v[ 0 ], v[ 1 ], v[ 2 ] );
      scene.AddTriangle( v[ 2 ], v[ 1 ], v[ 3 ] );
      scene.AddTriangle( v[ 1 ], v[ 0 ], v[ 3 ] );
      scene.AddTriangle( v[ 2 ], v[ 3 ], v[ 0 ] );

      return 4;
    }

    #endregion
  }
}
