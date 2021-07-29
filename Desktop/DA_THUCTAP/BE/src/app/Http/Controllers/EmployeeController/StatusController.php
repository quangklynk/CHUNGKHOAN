<?php

namespace App\Http\Controllers\EmployeeController;

use App\Http\Controllers\Controller;
use Illuminate\Http\Request;
use App\Models\Status;
use Illuminate\Support\Facades\DB;

class StatusController extends Controller
{
    public function getStatus (){
        $data = Status::all();
        if($data){
            return response()->json(['status' => 'successful',
                                    'data' => $data]);
        }
        return  response()->json(['status' => 'failed',
                                    'messege' => 'Empty List']);
    }

    public function createStatus(Request $request){
        try {
            DB::table('statuses')->updateOrInsert(
                ['id' => $request->id],
                [
                    'description' => $request->image,
                 ],
            );
            return response()->json(['status' => 'successful',
                                     'messege' => 'Add Status Success']);
        } catch (\Throwable $th) {
            return  response()->json(['status' => 'failed',
                                    'messege' => 'Add Status Failed']);
        }
    }

    public function getStatusByID($id){
        $data = Status::where('id', $id)->first();
        if($data){
            return response()->json(['status' => 'successful',
                                    'data' => $data]);
        }
        return  response()->json(['status' => 'failed',
                                'messege' => 'Empty Element']);
    }

    public function deleteStatusByID($id){
        try {
            DB::table('statuses')->where('id', $id)->delete();
            return response()->json(['status' => 'successful']);
        } catch (\Throwable $th) {
            return response()->json(['status' => 'failed',
                                     'error' => $th]);
        }
    }

    // public function deleteStatusByID($id){
    //     try {
    //         DB::table('Status')
    //           ->where('id', $id)
    //           ->update(['flag' => 0]);
    //         return response()->json(['status' => 'successful']);
    //     } catch (\Throwable $th) {
    //         return response()->json(['status' => 'failed',
    //                                  'error' => $th]);
    //     }
    // }

}
